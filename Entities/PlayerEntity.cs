using System;

namespace DotNetAndElastic.Entities
{
    public class PlayerEntity
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string DateOfBirth { get; set; }

        public string Position { get; set; }

        public int Height { get; set; }

        public string CurrentTeam { get; set; }
    }
}
