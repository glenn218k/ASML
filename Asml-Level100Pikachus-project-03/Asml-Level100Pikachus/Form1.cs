using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asml_Level100Pikachus.Factories;
using System.Resources;
using System.Threading;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Asml_Level100Pikachus
{
    public partial class Asml : Form
    {
        TargetManager tm;
        Camera m_exampleClass;
        DateTime start;
        PositionManager pm;
        Controller controller;

        static int numFriends = 0;
        static int numFoes = 0;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.kachu);
        System.Media.SoundPlayer playerSound = new System.Media.SoundPlayer(Properties.Resources.pkmtheme);
        System.Media.SoundPlayer playerInf = new System.Media.SoundPlayer(Properties.Resources.pikapika);

        public Asml()
        {
            InitializeComponent();

            m_exampleClass = new Camera();
            m_exampleClass.DataCaptured += new EventHandler<ExampleEventArgs>(m_exampleClass_DataCaptured);

            pictureBox_videoFeed.BackgroundImage = Properties.Resources.pikachuVid;
            pictureBox_videoFeed.BackgroundImageLayout = ImageLayout.Zoom;
            
            controller = Controller.GetInstance();

            controller.SetNum(4);
            pm = PositionManager.GetInstance();
            pm.lastMove = false;

            tm = TargetManager.GetInstance();
        }

        
        void m_exampleClass_DataCaptured(object sender, ExampleEventArgs e)
        {
            if (InvokeRequired)
            {
                
                Invoke(new EventHandler<ExampleEventArgs>(DataHandler), sender, e);
            }
            else
            {
                DataHandler(sender, e);
            }
        }

        private void DataHandler(object sender, ExampleEventArgs e)
        {
            pictureBox_videoFeed.Image = e.LastData.ToBitmap();
        }

        /// <summary>
        /// This method gets targets from a file when opened from the menu strip.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML Targets |*.xml|INI Targets|*.ini|All Files|*.*";
            DialogResult result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                listOfTargets.Items.Clear();
                numFoes = 0;
                numFriends = 0;
                label_name.Text = "";
                label_x.Text = "";
                label_y.Text = "";
                label_z.Text = "";
                label_friend.Text = "";
                string filePath = dialog.FileName;
                Controller controller = Controller.GetInstance();
                controller.LoadTargets(filePath);
                TargetManager tm = TargetManager.GetInstance();

                foreach (Target target in tm.TMTargets)
                {
                    listOfTargets.Items.Add(target);
                    if (target.friend == true)
                    {
                        numFriends++;
                    }
                    else
                    {
                        numFoes++;
                    }
                }
                label_numFoes.Text = Convert.ToString(numFoes);
                label_numFriends.Text = Convert.ToString(numFriends);
            }
        }

        /// <summary>
        /// This method updates the Target Info text boxes bases on what target is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listOfTargets_SelectedIndexChanged(object sender, EventArgs e)
        {
            Target target = listOfTargets.SelectedItem as Target;

            label_name.Text = target.name + " \"" + target.internalName + "\"";
            label_x.Text = Convert.ToString(target.x);
            label_y.Text = Convert.ToString(target.y);
            label_z.Text = Convert.ToString(target.z);
            if (target.friend == true)
            {
                label_friend.Text = "Friend";
            }
            else
            {
                label_friend.Text = "Foe";
            }
        }

        /// <summary>
        /// This method move to the selected target and then fire.
        /// If there is no selected target, it will just fire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fire_button_Click(object sender, EventArgs e)
        {
            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();

            if (controller.GetNum() > 0)
            {
                controller.SetNum(controller.GetNum() - 1);
                label_bullets.Text = Convert.ToString(controller.GetNum());
            }

            player.Play();

            Thread t = new Thread(controller.Fire);
            t.Start();
        }        

        /// <summary>
        /// This method resets the ASML to (0,0)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_reset_Click(object sender, EventArgs e)
        {
            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();

            Thread t = new Thread(controller.Launcher.Reset);
            t.Start();

            pm = PositionManager.GetInstance();
            pm.Reset();
            label_positionPosition.Text = "( 0.00 , -10.00 )";
        }

        private void imageTimer_Tick(object sender, EventArgs e)
        {
            if (label_live.ForeColor.Equals(System.Drawing.Color.Red) == true)
            {
                label_live.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                label_live.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void searchAndDestoryTimer_Tick(object sender, EventArgs e)
        {
            Controller cont = Controller.GetInstance();
            DateTime now = DateTime.Now;
            TimeSpan nowSpan = now.Subtract(start);
            label_timerTime.Text = nowSpan.Minutes + ":" + nowSpan.Seconds + ":" + nowSpan.Milliseconds;

            int bul = cont.GetNum();
            label_bullets.Text = Convert.ToString(controller.GetNum());
        }

        private void searchAndDestory_button_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            controller.SetNum(4);
            playerInf.PlayLooping();

            if (checkBox_liveVideo.Checked == true)
            {
                tm.ClearTargets();
            }

            button_reset.Enabled = false;
            searchAndDestory_button.Enabled = false;
            up_button.Enabled = false;
            down_button.Enabled = false;
            left_button.Enabled = false;
            right_button.Enabled = false;
            fire_button.Enabled = false;
            fileToolStripMenuItem.Enabled = false;
            listOfTargets.Enabled = false;
            radioButton_foe.Enabled = false;
            radioButton_friend.Enabled = false;
            radioButton_friendandfoe.Enabled = false;
            checkBox_liveVideo.Enabled = false;

            searchAndDestroyTimer.Enabled = true;

            SD sd = new SD();
            Thread t = new Thread(() => sd.SearchandDestroy(checkBox_reset.Checked, radioButton_friend.Checked, radioButton_foe.Checked, radioButton_friendandfoe.Checked, checkBox_liveVideo.Checked));
            t.Start();

            Thread test = new Thread(stopTimer);
            test.Start();
        }

        private void stopTimer()
        {
            while ((controller.GetNum() > 0))
            {
            }

            controller.SetNum(0);

            Thread.Sleep(250);


            playerInf.Stop();

            searchAndDestroyTimer.Enabled = false;
        }

        private void kill_button_Click(object sender, EventArgs e)
        {
            searchAndDestroyTimer.Enabled = false;

            playerInf.Stop();

            button_reset.Enabled = true;
            searchAndDestory_button.Enabled = true;
            up_button.Enabled = true;
            down_button.Enabled = true;
            left_button.Enabled = true;
            right_button.Enabled = true;
            fire_button.Enabled = true;
            fileToolStripMenuItem.Enabled = true;
            listOfTargets.Enabled = true;
            radioButton_foe.Enabled = true;
            radioButton_friend.Enabled = true;
            radioButton_friendandfoe.Enabled = true;
            checkBox_liveVideo.Enabled = true;
        }

        private void button_startVideo_Click(object sender, EventArgs e)
        {
            imageTimer.Enabled = true;
            label_live.Text = "LIVE";

            m_exampleClass.Start();
        }

        private void button_stopVideo_Click(object sender, EventArgs e)
        {
            m_exampleClass.Stop();

            imageTimer.Enabled = false;
            label_live.Text = "NOT LIVE";
            label_live.ForeColor = System.Drawing.Color.Black;
        }

        private void button_moveTo_Click(object sender, EventArgs e)
        {
            Target target = listOfTargets.SelectedItem as Target;

            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();

            Thread t = new Thread(() => controller.MoveTo(target.x, target.y));
            t.Start();

            Thread.Sleep(500);

            pm = PositionManager.GetInstance();
            label_positionPosition.Text = String.Format("( {0:0.00} , {1:0.00} )", pm.phi, pm.theta);
        }

        /// <summary>
        /// This method moves the ASML down by a small amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void down_button_Click(object sender, EventArgs e)
        {
            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();

            Thread t = new Thread(() => controller.MoveBy(0, -20));
            t.Start();

            Thread.Sleep(100);

            pm = PositionManager.GetInstance();
            label_positionPosition.Text = String.Format("( {0:0.00} , {1:0.00} )", pm.phi, pm.theta);
        }

        /// <summary>
        /// This method moves the ASML right by a small amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void right_button_Click(object sender, EventArgs e)
        {
            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();

            Thread t = new Thread(() => controller.MoveBy(140, 0));
            t.Start();

            Thread.Sleep(100);

            pm = PositionManager.GetInstance();
            label_positionPosition.Text = String.Format("( {0:0.00} , {1:0.00} )", pm.phi, pm.theta);
        }

        /// <summary>
        /// This method moves the ASML left by a small amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void left_button_Click(object sender, EventArgs e)
        {
            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();

            Thread t = new Thread(() => controller.MoveBy(-140, 0));
            t.Start();

            Thread.Sleep(100);

            pm = PositionManager.GetInstance();
            label_positionPosition.Text = String.Format("( {0:0.00} , {1:0.00} )", pm.phi, pm.theta);
        }

        /// <summary>
        /// This method moves the ASML up by a small amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void up_button_Click(object sender, EventArgs e)
        {
            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();

            Thread t = new Thread(() => controller.MoveBy(0, 20));
            t.Start();

            Thread.Sleep(100);

            pm = PositionManager.GetInstance();
            label_positionPosition.Text = String.Format("( {0:0.00} , {1:0.00} )", pm.phi, pm.theta);
        }
    }
}
