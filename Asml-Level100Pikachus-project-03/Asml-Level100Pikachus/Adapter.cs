using ASMLEngineSdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asml_Level100Pikachus
{
    /// <summary>
    /// Adapter
    /// </summary>
    public class MissileLauncherAdapter : IMissileLauncher
    {
        BuildDefender.MissileLauncher m_launcher;


        public MissileLauncherAdapter()
        {
            m_launcher = new BuildDefender.MissileLauncher();
        }

        public void Fire()
        {           
            m_launcher.command_Fire();           
        }

        /// <summary>
        /// This method makes the ASML move left or right, or up or down.
        /// </summary>
        /// <param name="phi"></param>
        /// <param name="theta"></param>
        public void MoveBy(double phi, double theta)
        {
            double magicNumber90 = 90.0 / 1750.0;
            double magicNumber45 = 45.0 / 870.0;
            double magicNumber22 = 22.5 / 410.0;
            double magicNumber10 = 10.0 / 140.0;
            double magicNumber5 = 5.0 / 58.0;

            int leftright = Convert.ToInt32(phi);
            int updown = Convert.ToInt32(theta);
            PositionManager pm = PositionManager.GetInstance();

            if (leftright > 0)// Figure out if we move right or left
            {
                double printphi = 0;
                if (phi < 0)
                    printphi = 0 - phi;
                else
                    printphi = phi;

                if (leftright > 1100)
                {
                    pm.phi += ((printphi) * (magicNumber90));
                }
                else if (leftright > 525)
                {
                    pm.phi += ((printphi) * (magicNumber45));
                }
                else if (leftright > 225)
                {
                    pm.phi += ((printphi) * (magicNumber22));
                }
                else if (leftright > 85)
                {
                    pm.phi += ((printphi) * (magicNumber10));
                }
                else
                {
                    pm.phi += ((printphi) * (magicNumber5));
                }

                if (pm.phi > 145.0)
                    pm.phi = 145.0;

                if (pm.lastMove == true)
                {
                    leftright += 45;
                }

                m_launcher.command_Right(leftright);
                pm.lastMove = false;
            }
            else if (leftright < 0)
            {
                double printphi = 0;
                if (phi < 0)
                    printphi = phi;
                else
                    printphi = 0 - phi;

                if (leftright < -1100)
                {
                    pm.phi += ((printphi) * (magicNumber90));
                }
                else if (leftright < -525)
                {
                    pm.phi += ((printphi) * (magicNumber45));
                }
                else if (leftright < -225)
                {
                    pm.phi += ((printphi) * (magicNumber22));
                }
                else if (leftright < -85)
                {
                    pm.phi += ((printphi) * (magicNumber10));
                }
                else
                {
                    pm.phi += ((printphi) * (magicNumber5));
                }

                if (pm.phi < -145.0)
                    pm.phi = -145.0;

                leftright = 0 - leftright;

                if (pm.lastMove == false)
                {
                    leftright += 45;
                }

                m_launcher.command_Left(leftright);
                pm.lastMove = true;
            }

            if (updown > 0)// Figure out if we move up or down
            {
                m_launcher.command_Up(updown);
                pm.theta += (theta / 8.0);
            }
            else if (updown < 0)
            {
                updown = 0 - updown;
                m_launcher.command_Down(updown);

                pm.theta += (theta / 8.0);
            }

            if (pm.theta > 45.0)
                pm.theta = 45.0;
            else if (pm.theta < -10.0)
                pm.theta = -10.0;

            Thread.Sleep(500);
        }

        /// <summary>
        /// This method is used to make the ASML move to a specified position
        /// </summary>
        /// <param name="phi"></param>
        /// <param name="theta"></param>
        public void MoveTo(double phi, double theta)
        {
            PositionManager pm = PositionManager.GetInstance();

            double distance = Math.Sqrt(Math.Pow(phi, 2) + Math.Pow(theta, 2));// Get the distance to the target
            double radangle = Math.Atan2(phi, theta);// Get the angle needed to move to be lined up to the target
            double degangle = radangle * (180 / Math.PI);// Convert from radians to degrees

            double rotate = degangle - pm.phi;

            if (rotate > 60.0 || rotate < -60.0)
                rotate = rotate * (1750.0 / 90.0);
            else if (rotate > 30.0 || rotate < -30.0)
                rotate = rotate * (870.0 / 45.0);
            else if (rotate > 14.0 || rotate < -14.0)
                rotate = rotate * (410.0 / 22.5);
            else if (rotate > 7.0 || rotate < -7.0)
                rotate = rotate * (140.0 / 10.0);
            else
                rotate = rotate * (58.0 / 5.0);

            MoveBy(rotate, 0);// Then rotate by that much
        }

        public void Reset()
        {
            MoveBy(6000, 0);// Move all the way right
            MoveBy(-2900, 0);// Then move left 1/2 of the max so it is centered
            MoveBy(0, 1000);// Move all the way up
            MoveBy(0, -700);// Move 1/2 of the way down so it is centered

            PositionManager pm = PositionManager.GetInstance();
            pm.Reset();
        }


        public double Phi
        {
            get { throw new NotImplementedException(); }
        }

        public double Theta
        {
            get { throw new NotImplementedException(); }
        }
    }
}
