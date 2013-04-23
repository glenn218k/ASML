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
        Camera cm;
        DateTime start;
        PositionManager pm;
        int numBullets = 4;
        int numFriends = 0;
        int numFoes = 0;

        public Asml()
        {
            InitializeComponent();

            pictureBox_videoFeed.BackgroundImage = Properties.Resources.pikachuVid;
            pictureBox_videoFeed.BackgroundImageLayout = ImageLayout.Zoom;
            
            tm = TargetManager.GetInstance();
            cm = Camera.GetInstance();
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
            Console.WriteLine("test");
            Console.ReadLine();

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

            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();
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
           /* if (listOfTargets.SelectedItem != null)
            {
                Target target = listOfTargets.SelectedItem as Target;
                controller.MoveTo(target.x, target.y);
            }*/ // this if will move to the selected target before firing.

            // this is for an awesome sound to play when fired.
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.kachu);
            player.Play();

            numBullets--;
            label_bullets.Text = Convert.ToString(numBullets);
            controller.Fire();
            //MessageBox.Show("Bang!");
        }

        /// <summary>
        /// This method is going to be used for increases movement speed while the
        /// move button is held down.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void moveTimer_Tick(object sender, EventArgs e)
        {
            //DateTime currentTime = DateTime.Now;
            //TimeSpan spanSince = currentTime.Subtract(m_startDown);

            //double acceleration = 5 * Math.Log(Math.Max(1, spanSince.TotalSeconds));
        }

        /// <summary>
        /// This method moves the ASML right by a small amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void right_button_Down(object sender, MouseEventArgs e)
        {
            //moveTimer.Enabled = true;
            //m_startDown = DateTime.Now;
            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();
            controller.MoveBy(100, 0);

            pm = PositionManager.GetInstance();
            label_positionPosition.Text = String.Format("( {0:0.00} , {1:0.00} )", pm.phi, pm.theta);
        }

        private void right_button_Up(object sender, MouseEventArgs e)
        {
            //moveTimer.Enabled = false;
        }

        /// <summary>
        /// This method moves the ASML left by a small amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void left_button_Down(object sender, MouseEventArgs e)
        {
            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();
            controller.MoveBy(-100,0);

            pm = PositionManager.GetInstance();
            label_positionPosition.Text = String.Format("( {0:0.00} , {1:0.00} )", pm.phi, pm.theta);

        }

        private void left_button_Up(object sender, MouseEventArgs e)
        {

        }

        /// <summary>
        /// This method moves the ASML up by a small amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void up_button_Down(object sender, MouseEventArgs e)
        {
            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();
            controller.MoveBy(0, 20);
        }

        private void up_button_Up(object sender, MouseEventArgs e)
        {

        }

        /// <summary>
        /// This method moves the ASML down by a small amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void down_button_Down(object sender, MouseEventArgs e)
        {
            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();
            controller.MoveBy(0, -20);
        }

        private void down_button_Up(object sender, MouseEventArgs e)
        {

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
            controller.Launcher.Reset();

            pm = PositionManager.GetInstance();
            pm.Reset();
            label_positionPosition.Text = "( 0.00 , 0.00 )";
        }

        private void GetImage()
        {
            Image<Bgr, byte> image = cm.cap.QueryFrame();
            Image windowsFormImage = image.ToBitmap();
            pictureBox_videoFeed.Image = windowsFormImage;
        }

        private void imageTimer_Tick(object sender, EventArgs e)
        {
            GetImage();
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
            DateTime now = DateTime.Now;
            TimeSpan nowSpan = now.Subtract(start);
            label_timerTime.Text = nowSpan.Minutes + ":" + nowSpan.Seconds + ":" + nowSpan.Milliseconds;
        }

        private void searchAndDestory_button_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;

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

            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();

            controller.Launcher.Reset();

            int i = 0;
            foreach (Target target in tm.TMTargets)
            {
                i++;
                if ((radioButton_friend.Checked == true) && (target.friend == true))
                {
                    controller.MoveTo(target.x, target.y);

                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.kachu);
                    player.Play();

                    numBullets--;
                    label_bullets.Text = Convert.ToString(numBullets);
                    controller.Fire();

                    if (i != Convert.ToInt32(label_numFriends.Text))
                        controller.MoveTo(-target.x, target.y);
                        //controller.Launcher.Reset();
                }
                else if ((radioButton_foe.Checked == true) && (target.friend == false))
                {
                    controller.MoveTo(target.x, target.y);

                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.kachu);
                    player.Play();

                    numBullets--;
                    label_bullets.Text = Convert.ToString(numBullets);
                    controller.Fire();

                    if (i != Convert.ToInt32(label_numFoes.Text))
                        controller.MoveTo(target.x * -1.2, target.y);
                        //controller.Launcher.Reset();
                }
                else if (radioButton_friendandfoe.Checked == true)
                {
                    controller.MoveTo(target.x, target.y);

                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.kachu);
                    player.Play();

                    numBullets--;
                    label_bullets.Text = Convert.ToString(numBullets);
                    controller.Fire();

                    if (i != tm.TMTargets.Count)
                        if (target.x > 0)
                            controller.MoveTo(target.x * -1.37, target.y);
                        else
                            controller.MoveTo(target.x * -1, target.y);
                        //controller.Launcher.Reset();
                }
            }

            /*searchAndDestroyTimer.Enabled = false;

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
            checkBox_liveVideo.Enabled = true;*/
        }

        private void kill_button_Click(object sender, EventArgs e)
        {
            searchAndDestroyTimer.Enabled = false;

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
        }

        private void button_stopVideo_Click(object sender, EventArgs e)
        {
            imageTimer.Enabled = false;
            label_live.Text = "NOT LIVE";
            label_live.ForeColor = System.Drawing.Color.Black;
            //pictureBox_videoFeed.BackgroundImage = Properties.Resources.pikachuVid;
            //pictureBox_videoFeed.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button_moveTo_Click(object sender, EventArgs e)
        {
            Target target = listOfTargets.SelectedItem as Target;

            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();
            controller.MoveTo(target.x, target.y);

            pm = PositionManager.GetInstance();
            label_positionPosition.Text = String.Format("( {0:0.00} , {1:0.00} )", (pm.phi * (180 / Math.PI)), (pm.theta * 180) / Math.PI);
        }
    }
}
