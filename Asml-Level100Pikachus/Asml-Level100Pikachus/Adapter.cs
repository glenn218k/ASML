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
        /// <param name="psi"></param>
        public void MoveBy(double phi, double psi)
        {
            int leftright = Convert.ToInt32(phi);
            int updown = Convert.ToInt32(psi);

            if (leftright > 0)// Figure out if we move right or left
            {
                m_launcher.command_Right(leftright);
            }
            else if (leftright < 0)
            {
                leftright = 0 - leftright;
                m_launcher.command_Left(leftright); 
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
        /// <param name="psi"></param>
        public void MoveTo(double phi, double psi)
        {
            Reset();// Reset the ASML to (0,0)
            double distance = Math.Sqrt(Math.Pow(phi, 2) + Math.Pow(psi, 2));// Get the distance to the target
            double angle = Math.Atan2(phi, psi);// Get the angle needed to move to be lined up to the target
            angle = angle * (180 / Math.PI);// Convert from radians to degrees
            double rotate = angle *(1850 / 90);// This gets the angle based in our units needed to rotate
            
            MoveBy(rotate, 0);// Then rotate by that much
           /* if(distance > 2000) // This is to adjust hight if needed.
            {
                MoveBy(0,100);
            }*/
        }

        public void Reset()
        {
            MoveBy(6500, 0);// Move all the way right
            MoveBy(-2980, 0);// Then move left 1/2 of the max so it is centered
            MoveBy(0, 880);// Move all the way up
            MoveBy(0, -580);// Move 1/2 of the way down so it is centered
        }
    }
    /// <summary>
    /// Adaptee
    /// </summary>
    public class AForeignMissileLauncher
    {
        /// <summary>
        /// Fires ze missiles
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public void FireZeMissile(double x, double y, double z)
        {
            Console.WriteLine("Fire ze missiles at ! {0}, {1}, {2}", x, y, z);
        }
    }
}
