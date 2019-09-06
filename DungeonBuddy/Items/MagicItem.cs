using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonBuddy.Items
{
    [Serializable]
    class MagicItem
    {
        private String name;
        private String rarity;
        private String value;

        public MagicItem(string name, string rarity, string value)
        {
            this.name = name;
            this.rarity = rarity;
            this.value = value;
        }

        public string Name { get => name; set => name = value; }
        public string Rarity { get => rarity; set => rarity = value; }
        public string Value { get => value; set => this.value = value; }
    }
}
