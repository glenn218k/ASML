using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Asml_Level100Pikachus
{
    class Camera
    {
        static Camera m_camera;
        public Capture cap;

        public static Camera GetInstance()
        {
            if (m_camera == null)
            {
                m_camera = new Camera();
            }

            return m_camera;
        }

        private Camera()
        {
            cap = new Capture();
        }
    }
}
