using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonBuddy.Entities
{
    [Serializable]
    public class NPC : Entity
    {
        private String bio;
        private String location;
        private String sex;

        //Traits
        private String appearance;
        private String mannerism;
        private String interactionStyle;
        private String flaw_secret;
        private String talent;

        //Constructor with default blank bio/traits.
        public NPC(String name, String sex, String race, String location)
        {
            this.name = name;
            this.Sex = sex;
            this.race = race;
            this.Location = location;
            this.Bio = "";
        }

        //Constructor with blank bio.
        public NPC(String name, String sex, String race, String location, String appearance, String mannerism, String interactionStyle, String flaw_secret, String talent)
        {
            this.name = name;
            this.Sex = sex;
            this.race = race;
            this.Location = location;
            this.appearance = appearance;
            this.mannerism = mannerism;
            this.interactionStyle = interactionStyle;
            this.flaw_secret = flaw_secret;
            this.talent = talent;
            this.Bio = "";
        }

        //Full NPC
        public NPC(String name, String sex, String race, String location, String appearance, String mannerism, String interactionStyle, String flaw_secret, String talent, String bio)
        {
            this.name = name;
            this.Sex = sex;
            this.race = race;
            this.Location = location;
            this.appearance = appearance;
            this.mannerism = mannerism;
            this.interactionStyle = interactionStyle;
            this.flaw_secret = flaw_secret;
            this.talent = talent;
            this.Bio = bio;
        }

        public string Bio { get => bio; set => bio = value; }
        public string Location { get => location; set => location = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Appearance { get => appearance; set => appearance = value; }
        public string Mannerism { get => mannerism; set => mannerism = value; }
        public string InteractionStyle { get => interactionStyle; set => interactionStyle = value; }
        public string Flaw_secret { get => flaw_secret; set => flaw_secret = value; }
        public string Talent { get => talent; set => talent = value; }
    }
}
