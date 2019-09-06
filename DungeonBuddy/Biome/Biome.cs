using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonBuddy.Biome
{
    [Serializable]
    abstract class Biome
    {
        protected String type;
        protected int movementPenalty = 1;
        protected Weather weather = new ArcticWeather();

        abstract public void generateWeather();

        public string Type { get => type; set => type = value; }
        public int MovementPenalty { get => movementPenalty; set => movementPenalty = value; }
        public Weather Weather { get => weather; set => weather = value; }
    }
}
