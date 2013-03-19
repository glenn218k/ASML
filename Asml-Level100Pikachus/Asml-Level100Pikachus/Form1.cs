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
                Factory factory = Factory.GetInstance();
                FileReader reader = factory.CreateReader(filePath);
                List<Target> targets = reader.ReadLines(filePath);

                TargetManager tm = TargetManager.GetInstance();
                tm.ClearTargets();
                tm.AddTargets(targets);

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
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Josh\Documents\GitHub\ASML\Asml-Level100Pikachus\Asml-Level100Pikachus\Resources\kachu.wav");
            player.Play();
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
            moveTimer.Enabled = true;
            m_startDown = DateTime.Now;
        }

        private void right_button_Up(object sender, MouseEventArgs e)
        {
            moveTimer.Enabled = false;
        }

        private void left_button_Down(object sender, MouseEventArgs e)
        {

        }

        private void left_button_Up(object sender, MouseEventArgs e)
        {

        }

        private void up_button_Down(object sender, MouseEventArgs e)
        {

        }

        private void up_button_Up(object sender, MouseEventArgs e)
        {

        }

        private void down_button_Down(object sender, MouseEventArgs e)
        {

        }

        private void down_button_Up(object sender, MouseEventArgs e)
        {

        }
    }
}
