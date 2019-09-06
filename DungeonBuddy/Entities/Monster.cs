using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonBuddy.Entities
{
    [Serializable]
    class Monster : Entity
    {
        private bool isNPC = false;

        public Monster(String name, int initiative, int maxHP, int ac)
        {
            this.name = name;
            this.maxHP = maxHP;
            this.currentHP = maxHP;
            this.initiative = initiative;
            this.armorClass = ac;
        }

        public bool IsNPC { get => isNPC; set => isNPC = value; }
    }
}
