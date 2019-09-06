using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonBuddy.Biome;

namespace DungeonBuddy.Entities
{
    [Serializable]
    class Party
    {
        private List<Player> partyMembers;
        private int poundsFood = 0;
        private int playerMovement = 0;
        private int leftoverMovement = 0;
        private int foodForaged = 0;
        private int rationsMultiplier = 1;
        private double foodRemainingPounds;
        private int daysWithoutFood = 0;
        private Biome.Biome currentBiome = new ArcticBiome();

        public Party()
        {
            partyMembers = new List<Player>();
        }

        public List<Player> PartyMembers { get => partyMembers; set => partyMembers = value; }
        public int PoundsFood { get => poundsFood; set => poundsFood = value; }
        public int PlayerMovement { get => playerMovement; set => playerMovement = value; }
        public int FoodForaged { get => foodForaged; set => foodForaged = value; }
        public int RationsMultiplier { get => rationsMultiplier; set => rationsMultiplier = value; }
        public double FoodRemainingPounds { get => foodRemainingPounds; set => foodRemainingPounds = value; }
        public Biome.Biome CurrentBiome { get => currentBiome; set => currentBiome = value; }
        public int LeftoverMovement { get => leftoverMovement; set => leftoverMovement = value; }
        public int DaysWithoutFood { get => daysWithoutFood; set => daysWithoutFood = value; }
    }
}
