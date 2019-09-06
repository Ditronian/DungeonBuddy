using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonBuddy.Entities
{
    [Serializable]
    public class Entity
    {
        protected String name;
        protected String race;
        protected int maxHP;
        protected int currentHP;
        protected int initiative;
        protected int armorClass;

        public string Name { get => name; set => name = value; }
        public string Race { get => race; set => race = value; }
        public int MaxHP { get => maxHP; set => maxHP = value; }
        public int CurrentHP { get => currentHP; set => currentHP = value; }
        public int Initiative { get => initiative; set => initiative = value; }
        public int ArmorClass { get => armorClass; set => armorClass = value; }
    }
}
