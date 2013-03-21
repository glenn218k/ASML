using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asml_Level100Pikachus
{
    public class Target
    {
        public Target(){ }

        /// <summary>
        /// This method changes how the target will be presented in the list box
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string friendFoe;
            if (friend == true)
            {
                friendFoe = "Friend";
            }
            else
            {
                friendFoe = "Foe";
            }
            return string.Format("{0} : {1} ", name, friendFoe);
        }

        // get/set for all the variables
        public string name
        {
            get;
            set;
        }

        public string internalName
        {
            get;
            set;
        }

        public double x
        {
            get;
            set;
        }

        public double y
        {
            get;
            set;
        }

        public double z
        {
            get;
            set;
        }

        public bool friend
        {
            get;
            set;
        }
    }
}