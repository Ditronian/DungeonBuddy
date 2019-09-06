using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonBuddy.Biome
{
    [Serializable]
    class ArcticBiome : Biome
    {
        public ArcticBiome()
        {
            this.movementPenalty = 2;
            generateWeather();
        }
        override public void generateWeather()
        {
            weather = new ArcticWeather();
        }
    }
}
