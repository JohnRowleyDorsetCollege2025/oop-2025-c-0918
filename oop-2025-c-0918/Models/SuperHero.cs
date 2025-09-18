using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_c_0918.Models
{
    public class SuperHero
    {
        public string Name { get; set; } = String.Empty;
        public string Alias { get; set; } = String.Empty;

        public string SpecialSkill { get; set; } = "None";

        public override string ToString()
        {
            return $"{Name}:{Alias}:{SpecialSkill}";
        }
    }
}
