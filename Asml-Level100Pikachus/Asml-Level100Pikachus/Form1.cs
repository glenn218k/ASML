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

namespace Asml_Level100Pikachus
{
    public partial class Asml : Form
    {
        //DateTime m_startDown;

        TargetManager tm;

        public Asml()
        {
            InitializeComponent();

            tm = TargetManager.GetInstance();

            //tm.AddedTarget += ;
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
                textBox_name.Text = "";
                textBox_x.Text = "";
                textBox_y.Text = "";
                textBox_z.Text = "";
                textBox_friend.Text = "";
                string filePath = dialog.FileName;
                Controller controller = Controller.GetInstance();
                controller.LoadTargets(filePath);
                TargetManager tm = TargetManager.GetInstance();

                int numFriends = 0;
                int numFoes = 0;
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

            textBox_name.Text = target.name + " \"" + target.internalName + "\"";
            textBox_x.Text = Convert.ToString(target.x);
            textBox_y.Text = Convert.ToString(target.y);
            textBox_z.Text = Convert.ToString(target.z);
            if (target.friend == true)
            {
                textBox_friend.Text = "Friend";
            }
            else
            {
                textBox_friend.Text = "Foe";
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
            controller.Launcher.Reset(); ;
        }
    }
}
