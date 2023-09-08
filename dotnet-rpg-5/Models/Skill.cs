﻿#region Usings
using System.Collections.Generic;
#endregion

namespace dotnet_rpg.Models
{
    public class Skill
    {
        #region Properties Skill
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public List<Character> Characters { get; set; }
        #endregion
    }
}