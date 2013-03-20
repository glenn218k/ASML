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

namespace Asml_Level100Pikachus
{
    public partial class Asml : Form
    {
        DateTime m_startDown;

        public Asml()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML Targets |*.xml|INI Targets|*.ini|All Files|*.*";
            DialogResult result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                listOfTargets.Items.Clear();
                string filePath = dialog.FileName;
<<<<<<< HEAD
<<<<<<< HEAD
                Factory factory = Factory.GetInstance();
                FileReader reader = factory.CreateReader(filePath);
                List<Target> targets = reader.ReadLines(filePath);

                TargetManager tm = TargetManager.GetInstance();
                tm.ClearTargets();
                tm.AddTargets(targets);
=======
                Controller controller = Controller.GetInstance();
                controller.LoadTargets(filePath);
                TargetManager tm = TargetManager.GetInstance();
>>>>>>> origin/jon
=======
                Controller controller = Controller.GetInstance();
                controller.LoadTargets(filePath);
                TargetManager tm = TargetManager.GetInstance();
>>>>>>> origin/jon

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

        private void listOfTargets_SelectedIndexChanged(object sender, EventArgs e)
        {
            Target target = listOfTargets.SelectedItem as Target;

            textBox_name.Text = target.name;
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
        }

        private void fire_button_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Josh\Documents\GitHub\ASML\Asml-Level100Pikachus\Asml-Level100Pikachus\Resources\kachu.wav");
            player.Play();
=======
=======
>>>>>>> origin/jon
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Josh\Documents\GitHub\ASML\Asml-Level100Pikachus\Asml-Level100Pikachus\Resources\kachu.wav");
           // player.Play();
            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();
            controller.Fire();  
<<<<<<< HEAD
>>>>>>> origin/jon
=======
>>>>>>> origin/jon
            MessageBox.Show("Bang!");
        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan spanSince = currentTime.Subtract(m_startDown);

            double acceleration = 5 * Math.Log(Math.Max(1, spanSince.TotalSeconds));
        }

        private void right_button_Down(object sender, MouseEventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            moveTimer.Enabled = true;
            m_startDown = DateTime.Now;
=======
=======
>>>>>>> origin/jon
            //moveTimer.Enabled = true;
            //m_startDown = DateTime.Now;
            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();
            controller.MoveBy(100, 0); 
<<<<<<< HEAD
>>>>>>> origin/jon
=======
>>>>>>> origin/jon
        }

        private void right_button_Up(object sender, MouseEventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            moveTimer.Enabled = false;
=======
            //moveTimer.Enabled = false;
>>>>>>> origin/jon
=======
            //moveTimer.Enabled = false;
>>>>>>> origin/jon
        }

        private void left_button_Down(object sender, MouseEventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD

=======
            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();
            controller.MoveBy(-100,0); 
>>>>>>> origin/jon
=======
            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();
            controller.MoveBy(-100,0); 
>>>>>>> origin/jon
        }

        private void left_button_Up(object sender, MouseEventArgs e)
        {

        }

        private void up_button_Down(object sender, MouseEventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD

=======
            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();
            controller.MoveBy(0, 20);
>>>>>>> origin/jon
=======
            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();
            controller.MoveBy(0, 20);
>>>>>>> origin/jon
        }

        private void up_button_Up(object sender, MouseEventArgs e)
        {

        }

        private void down_button_Down(object sender, MouseEventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD

=======
            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();
            controller.MoveBy(0, -20);
>>>>>>> origin/jon
=======
            Controller controller = Controller.GetInstance();
            controller.Launcher = new MissileLauncherAdapter();
            controller.MoveBy(0, -20);
>>>>>>> origin/jon
        }

        private void down_button_Up(object sender, MouseEventArgs e)
        {

        }
    }
}
