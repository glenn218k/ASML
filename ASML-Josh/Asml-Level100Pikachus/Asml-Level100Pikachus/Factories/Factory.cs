using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Asml_Level100Pikachus;

namespace Asml_Level100Pikachus.Factories
{
    public class Factory
    {
        static Factory m_factory;

        public static Factory GetInstance()
        {
            if (m_factory == null)
                m_factory = new Factory();

            return m_factory;
        }

        private Factory()
        {
        }

        /// <summary>
        /// creates a filereader depending on the filepath
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public FileReader CreateReader(string filePath)
        {
            FileReader reader = null;

            string ext = Path.GetExtension(filePath);
            ext = ext.ToLower();

            // if .ini make an ini, if .xml make an xml
            if (ext == ".ini")
            {
                reader = new INIReader();
            }
            else if (ext == ".xml")
            {
                reader = new XMLReader();
            }
            else
            {

            }

            return reader;
        }
    }
}
