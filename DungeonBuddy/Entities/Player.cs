using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonBuddy.Entities
{
    [Serializable]
    public class Player : Entity
    {

        private int passivePerception;
        private char size;
        private bool isNpc = false;

        public Player(String name, String race, int passivePerception, char size)
        {
            this.name = name;
            this.race = race;
            this.passivePerception = passivePerception;
            this.Size = size;
            
        }

        public int PassivePerception { get => passivePerception; set => passivePerception = value; }
        public char Size { get => size; set => size = value; }
        public bool IsNpc { get => isNpc; set => isNpc = value; }
    }

}
