using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asml_Level100Pikachus
{
    public class TargetManager
    {
<<<<<<< HEAD
=======
        public delegate void AddTarget(object sender, Target target);

        public event AddTarget AddedTarget;

        /*public void AddTarget(Target target)
        {
            if (AddedTarget != null)
            {
                AddedTarget(this, target);
            }
        }*/

>>>>>>> origin/jon
        static TargetManager m_manager;

        /// <summary>
        /// This method gets the single instance of the target manager.
        /// </summary>
        /// <returns></returns>
        public static TargetManager GetInstance()
        {
            if (m_manager == null)
                m_manager = new TargetManager();

            return m_manager;
        }

        /// <summary>
        /// This method adds targets to the target manager.
        /// </summary>
        /// <param name="targets"></param>
        public virtual void AddTargets(List<Target> targets)
        {
            foreach (Target target in targets)
            {
                TMTargets.Insert(TMTargets.Count, target);
            }
        }

        private TargetManager()
        {
            TMTargets = new List<Target>();
        }

        public List<Target> TMTargets
        {
            get;
            set;
        }

        /// <summary>
        /// This method clears the list of targets from the target manager.
        /// </summary>
        public void ClearTargets()
        {
            TMTargets.Clear();
        }
    }
}
