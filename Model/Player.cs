using System;

namespace DotNetAndElastic.Model
{
    public class Player
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Position { get; set; }

        public int Height { get; set; }

        public string CurrentTeam { get; set; }
    }
}
