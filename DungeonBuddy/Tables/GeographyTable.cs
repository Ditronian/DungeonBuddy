using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonBuddy.Tables
{
    class GeographyTable
    {
        String type;
        HashSet<String> names = new HashSet<String>();

        //Adds values to the name lists
        public GeographyTable(String type)
        {
            this.type = type;

            //Adds the three sets of names to their lists
            foreach (String line in File.ReadLines("Names/" + type + "Names.txt", Encoding.UTF8))
            {
                if(!names.Contains(line)) names.Add(line);
            }
        }

        public String getName()
        {
            String name = names.ElementAt(Program.random.Next(names.Count));
            return name;
        }
    }
}
