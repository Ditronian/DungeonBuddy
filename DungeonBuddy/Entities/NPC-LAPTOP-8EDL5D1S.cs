using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonBuddy.Entities
{
    class NPC : Entity
    {
        private String bio;

        public NPC(String firstName, String lastName, String race, String bio)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.race = race;
            this.bio = bio;
        }
        
    }
}
