using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asml_Level100Pikachus
{
    public class TargetManager
    {
        static TargetManager m_manager;

        public static TargetManager GetInstance()
        {
            if (m_manager == null)
                m_manager = new TargetManager();

            return m_manager;
        }

        public virtual void AddTargets(List<Target> targets)
        {
            foreach (Target target in targets)
            {
                TMTargets.Insert(TMTargets.Count, target);
            }
        }

        public void PrintTargets()
        {
          
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

        public void ClearTargets()
        {
            TMTargets.Clear();
        }
    }
}
