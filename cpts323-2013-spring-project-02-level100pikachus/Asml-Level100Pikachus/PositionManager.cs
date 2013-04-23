using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asml_Level100Pikachus
{
    class PositionManager
    {
        static PositionManager m_pmanager;

        /// <summary>
        /// This method gets the single instance of the target manager.
        /// </summary>
        /// <returns></returns>
        public static PositionManager GetInstance()
        {
            if (m_pmanager == null)
            {
                m_pmanager = new PositionManager();
            }

            return m_pmanager;
        }

        public double phi
        {
            get;
            set;
        }

        public double theta
        {
            get;
            set;
        }

        public void Reset()
        {
            phi = 0;
            theta = 0;
        }
    }
}
