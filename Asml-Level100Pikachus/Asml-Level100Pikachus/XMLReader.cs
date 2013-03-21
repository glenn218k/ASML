﻿using System;
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

<<<<<<< HEAD
                // These are the names to use when the target is a friend.
=======
>>>>>>> Should be final update.
                string[] goodNames = new string[12];
                goodNames[0] = "Bulbasaur";
                goodNames[1] = "Ivysaur";
                goodNames[2] = "Venusaur";
                goodNames[3] = "Charmander";
                goodNames[4] = "Charmeleon";
                goodNames[5] = "Charizard";
                goodNames[6] = "Squirtle";
                goodNames[7] = "Wartortle";
                goodNames[8] = "Blastoise";
                goodNames[9] = "Pikachu";
                goodNames[10] = "Raichu";
                goodNames[11] = "Scizor";

<<<<<<< HEAD
                // These are the names to use when the target is a foe.
=======
>>>>>>> Should be final update.
                string[] badNames = new string[7];
                badNames[0] = "Meowth";
                badNames[1] = "Arbok";
                badNames[2] = "Victreebel";
                badNames[3] = "Mewtwo";
                badNames[4] = "Zubat";
                badNames[5] = "Geodude";
                badNames[6] = "Jigglypuff";

                Random rand = new Random();
                int i = 0;

                //go through each node
                foreach (XmlNode node in nodes)
                {
                    Target target = new Target();

                    //convert all the attributes
<<<<<<< HEAD
                    string name = node.Attributes["name"].Value;
=======
                    //string name = node.Attributes["Name"].Value;
>>>>>>> Should be final update.
                    double xPos = Convert.ToDouble(node.Attributes["xPos"].Value);
                    double yPos = Convert.ToDouble(node.Attributes["yPos"].Value);
                    double zPos = Convert.ToDouble(node.Attributes["zPos"].Value);
                    bool isFriend = Convert.ToBoolean(node.Attributes["isFriend"].Value);

                    XmlAttribute attribute = node.Attributes[0];

                    //set the attributes to the target
<<<<<<< HEAD
                    target.internalName = name;
=======
                    //target.internalName = name;
>>>>>>> Should be final update.
                    target.friend = isFriend;
                    target.x = xPos;
                    target.y = yPos;
                    target.z = zPos;

                    if (target.friend == true)
                    {
                        i = rand.Next(11);
                        target.name = goodNames[i];
                    }
                    else
                    {
                        i = rand.Next(6);
                        target.name = badNames[i];
                    }

                    //insert the target into the list of Targets
                    targets.Insert(targets.Count, target);
                    i++;
                }
            }

            return targets;
        }
    }
}
