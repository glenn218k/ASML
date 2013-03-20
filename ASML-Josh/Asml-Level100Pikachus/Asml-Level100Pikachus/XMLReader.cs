using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace Asml_Level100Pikachus
{
    public sealed class XMLReader : FileReader
    {
        public XMLReader(){}

        /// <summary>
        /// override of the ReadLines for an xmlreader
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public override List<Target> ReadLines(string filePath)
        {
            // make a list of Targets
            List<Target> targets = new List<Target>();

            using (XmlTextReader reader = new XmlTextReader(filePath))
            {
                // read in an xml file
                XmlDocument document = new XmlDocument();
                document.Load(reader);

                //set the mainnode
                XmlNode mainNode = document.FirstChild;

                if (mainNode.Name == "xml")
                {
                    mainNode = mainNode.NextSibling;

                }

                //if the mainnode isnt targets, throw exception
                if (mainNode.Name == "Targets")
                {
                }
                else
                {
                    throw new Exception("Invalid xml format.");
                }

                //make a list of nodes
                XmlNodeList nodes = mainNode.ChildNodes;

                string[] names = new string[11];
                names[0] = "Bulbasaur";
                names[1] = "Ivysaur";
                names[2] = "Venasaur";
                names[3] = "Charmander";
                names[4] = "Charmeleon";
                names[5] = "Charizard";
                names[6] = "Squirtle";
                names[7] = "Wartortle";
                names[8] = "Blastoise";
                names[9] = "Pikachu";//24
                names[10] = "Raichu";//25
                Random rand = new Random();
                int i = 1;

                //go through each node
                foreach (XmlNode node in nodes)
                {
                    Target target = new Target();

                    //convert all the attributes
                    double xPos = Convert.ToDouble(node.Attributes["xPos"].Value);
                    double yPos = Convert.ToDouble(node.Attributes["yPos"].Value);
                    double zPos = Convert.ToDouble(node.Attributes["zPos"].Value);
                    bool isFriend = Convert.ToBoolean(node.Attributes["isFriend"].Value);

                    XmlAttribute attribute = node.Attributes[0];
                    i = rand.Next(11);

                    //set the attributes to the target
                    target.name = names[i];
                    target.friend = isFriend;
                    target.x = xPos;
                    target.y = yPos;
                    target.z = zPos;

                    //insert the target into the list of Targets
                    targets.Insert(targets.Count, target);
                }
            }

            return targets;
        }
    }
}
