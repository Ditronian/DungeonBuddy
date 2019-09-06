using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonBuddy.Mechanics;

namespace DungeonBuddy.Biome
{
    [Serializable]
    abstract class Weather
    {
        protected String type;
        protected String effect;
        protected int duration = 1;

        abstract public string getWeatherType();
        abstract public string getWeatherEffect();

        public string Type { get => type; set => type = value; }
        public string Effect { get => effect; set => effect = value; }
        public int Duration { get => duration; set => duration = value; }
    }
}
