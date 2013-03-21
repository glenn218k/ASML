using ASMLEngineSdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asml_Level100Pikachus.Factories;

namespace Asml_Level100Pikachus
{
    /// <summary>
    /// Client
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// Runs the missile launcher 
        /// </summary>
        public void Fire()
        {
            Launcher.Fire();
        }

        public void MoveBy(double phi, double psi)
        {
            Launcher.MoveBy(phi, psi);
        }

        public void MoveTo(double phi, double psi)
        {
            Launcher.MoveTo(phi, psi);
        }

        public void LoadTargets(string filePath)
        {
            Factory factory = Factory.GetInstance();
            FileReader reader = factory.CreateReader(filePath);
            List<Target> targets = reader.ReadLines(filePath);

            TargetManager tm = TargetManager.GetInstance();
            tm.ClearTargets();
            tm.AddTargets(targets);
        }

        /// <summary>
        /// Reference to a missile launcher.
        /// </summary>
        public IMissileLauncher Launcher
        {
            get;
            set;
        }

        private static Controller controllerInstance;

        private Controller()
        {

        }

        public static Controller GetInstance()
        {
            if (controllerInstance == null)
            {
                controllerInstance = new Controller();
            }            
            return controllerInstance;            
        }
    }
}
