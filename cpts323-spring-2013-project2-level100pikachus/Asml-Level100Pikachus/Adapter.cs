using ASMLEngineSdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asml_Level100Pikachus
{
    /// <summary>
    /// Adapter
    /// </summary>
    public class MissileLauncherAdapter : IMissileLauncher
    {
        BuildDefender.MissileLauncher m_launcher;

        //  AForeignMissileLauncher m_launcher;

        public MissileLauncherAdapter()
        {
            m_launcher = new BuildDefender.MissileLauncher(); // new AForeignMissileLauncher();
        }

        /// <summary>
        /// This is the implementation of the request
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void FireMissile(double x, double y) //dont think we need this
        {
            // We know how to correctly call the class that does what we want.  
            // So we provide the interface to just send x, y and then provide 0 for z.
            m_launcher.command_Fire();//.FireZeMissile(x, y, 0);
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

                m_launcher.command_Right(leftright);
                pm.phi += (printphi / 19.7);
            }
            else if (leftright < 0)
            {
                double printphi = 0;
                if (phi < 0)
                    printphi = phi;
                else
                    printphi = 0 - phi;

                leftright = 0 - leftright;
                m_launcher.command_Left(leftright);
                pm.phi += (printphi / 19.7);
            }

            if (updown > 0)// Figure out if we move up or down
            {
                m_launcher.command_Up(updown);
            }
            else if (updown < 0)
            {
                updown = 0 - updown;
                m_launcher.command_Down(updown);
            }
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
            //double degangle = radangle * (180 / Math.PI);// Convert from radians to degrees

            double rotate = radangle - pm.phi;

            rotate = radangle * ((1420 * 2) / Math.PI);// This gets the angle based in our units needed to rotate
           /*if (rotate > 0)
                rotate = rotate * 1.01;

            else
                rotate = rotate * 11;
            */
            MoveBy(rotate, 0);// Then rotate by that much
            /*if(distance > 20) // This is to adjust hight if needed.
            {
                MoveBy(0, 25);
            }*/
        }

        public void Reset()
        {
            //m_launcher.command_reset();
            MoveBy(6000, 0);// Move all the way right
            MoveBy(-2770, 0);// Then move left 1/2 of the max so it is centered
            MoveBy(0, 1000);// Move all the way up
            MoveBy(0, -650);// Move 1/2 of the way down so it is centered

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
