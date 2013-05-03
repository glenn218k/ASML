using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace Asml_Level100Pikachus
{
    public sealed class INIReader : FileReader
    {
        public INIReader(){}

        /// <summary>
        /// override for the ReadLines method for an ini reader
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public override List<Target> ReadLines(string filePath)
        {
            List<Target> targets = new List<Target>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                // First check is if the line is a blank line.
                if (line != "")
                {
                    // If not a blank line, trim the lines and split the lines delimited by an = sign
                    string trimmedLine = line.Trim();
                    string[] splits = trimmedLine.Split('=');

                    // If the trimmed line starts and ends with square brackets, then it is a group and is ok
                    if ((trimmedLine.StartsWith("[")) && (trimmedLine.EndsWith("]")))
                    {
                        Target target = new Target();
                        targets.Insert(targets.Count, target);
                    }
                    // If the line starts with and does not end with, or ends with and does not start with square brackets, we have a problem
                    // so throw exception.
                    else if ((trimmedLine.StartsWith("[") && !trimmedLine.EndsWith("]")) || (!trimmedLine.StartsWith("[") && trimmedLine.EndsWith("]")))
                    {
                        throw new Exception("Invalid .ini format.");
                    }
                    else if (trimmedLine.StartsWith(";"))
                    {
                    }
                    // If the line was not split into 2 strings, the line is bad so throw exception.
                    else if (splits.Length != 2)
                    {
                        throw new Exception("Invalid .ini format.");
                    }
                    else if (splits.Length == 2)
                    {
                        splits[0] = splits[0].Trim();
                        splits[1] = splits[1].Trim();

                        //check the left side of the = to know which field to set
                        if (splits[0].ToLower() == "name")
                        {
                            targets.Last().internalName = splits[1];
                        }
                        else if (splits[0].ToLower() == "x")
                        {
                            double x = Convert.ToDouble(splits[1]);
                            targets.Last().x = x;
                        }
                        else if (splits[0].ToLower() == "y")
                        {
                            double y = Convert.ToDouble(splits[1]);
                            targets.Last().y = y;
                        }
                        else if (splits[0].ToLower() == "z")
                        {
                            double z = Convert.ToDouble(splits[1]);
                            targets.Last().z = z;
                        }
                        else if (splits[0].ToLower() == "friend")
                        {
                            // set true/false appropriately
                            if (splits[1].ToLower() == "yes")
                            {
                                targets.Last().friend = true;
                            }
                            else
                            {
                                targets.Last().friend = false;
                            }
                        }
                        else
                        {

                        }
                    }
                }
                // Else the line is a blank line, and there is nothing wrong with that
                else
                {

                }
            }

            // These are the names to use when the target is a friend.
            string[] goodNames = new string[17];
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
            goodNames[12] = "Scyther";
            goodNames[13] = "Dragonite";
            goodNames[14] = "Gengar";
            goodNames[15] = "Hitmonchan";
            goodNames[16] = "Hitmonlee";

            // These are the names to use when the target is a foe.
            string[] badNames = new string[12];
            badNames[0] = "Meowth";
            badNames[1] = "Arbok";
            badNames[2] = "Victreebel";
            badNames[3] = "Mewtwo";
            badNames[4] = "Zubat";
            badNames[5] = "Geodude";
            badNames[6] = "Jigglypuff";
            badNames[7] = "Wigglytuff";
            badNames[8] = "Jinx";
            badNames[9] = "Foongus";
            badNames[10] = "Amoonguss";
            badNames[11] = "Litwick";

            Random rand = new Random();
            int i = 0;

            // This sets the targets name based on being a friend or foe.
            foreach (Target target in targets)
            {
                if (target.friend == true)
                {
                    i = rand.Next(17);
                    target.name = goodNames[i];
                }
                else
                {
                    i = rand.Next(12);
                    target.name = badNames[i];
                }
            }

            // If we get to this point, none of the lines were improperly formated, so we return true
            return targets;
        }
    }
}
