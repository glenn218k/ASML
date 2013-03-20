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

        public void MoveBy(double phi, double psi)
        {
            int leftright = Convert.ToInt32(phi);
            int updown = Convert.ToInt32(psi);

            if (leftright > 0)
            {
                m_launcher.command_Right(leftright);
            }
            else if (leftright < 0)
            {
                leftright = 0 - leftright;
                m_launcher.command_Left(leftright); 
            }
            if (updown > 0)
            {
                m_launcher.command_Up(updown);
            }
            else if (updown < 0)
            {
                updown = 0 - updown;
                m_launcher.command_Down(updown);
            }
        }

        public void MoveTo(double phi, double psi)
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
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
