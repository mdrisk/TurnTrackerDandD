using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TurnTrackerDandD.Models
{
    public class Combatant
    {
        public int Initiative { get; set; }
        public string Name { get; set; }
        public List<string> Banes { get; set; }
        public List<string> Boons { get; set; }
        public List<Image> Icons { get; set; }

        public Combatant()
        {
            Initiative = 0;
            Name = "";
            Banes = new List<string>();
            Boons = new List<string>();
            Icons = new List<Image>();

        }

        
    }
}
