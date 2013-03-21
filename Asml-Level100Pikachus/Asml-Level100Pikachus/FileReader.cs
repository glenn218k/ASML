using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Asml_Level100Pikachus
{
    public abstract class FileReader
    {
        public FileReader() { }
        /// <summary>
        /// abstract ReadLines method
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public abstract List<Target> ReadLines(string filePath);
    }
}
