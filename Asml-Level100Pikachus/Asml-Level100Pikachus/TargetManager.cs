using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asml_Level100Pikachus
{
    public class TargetManager
    {
        static TargetManager m_manager;

<<<<<<< HEAD
        /// <summary>
        /// This method gets the single instance of the target manager.
        /// </summary>
        /// <returns></returns>
=======
>>>>>>> Should be final update.
        public static TargetManager GetInstance()
        {
            if (m_manager == null)
                m_manager = new TargetManager();

            return m_manager;
        }

<<<<<<< HEAD
        /// <summary>
        /// This method adds targets to the target manager.
        /// </summary>
        /// <param name="targets"></param>
=======
>>>>>>> Should be final update.
        public virtual void AddTargets(List<Target> targets)
        {
            foreach (Target target in targets)
            {
                TMTargets.Insert(TMTargets.Count, target);
            }
        }

<<<<<<< HEAD
=======
        public void PrintTargets()
        {
          
        }

>>>>>>> Should be final update.
        private TargetManager()
        {
            TMTargets = new List<Target>();
        }

        public List<Target> TMTargets
        {
            get;
            set;
        }

<<<<<<< HEAD
        /// <summary>
        /// This method clears the list of targets from the target manager.
        /// </summary>
=======
>>>>>>> Should be final update.
        public void ClearTargets()
        {
            TMTargets.Clear();
        }
    }
}
