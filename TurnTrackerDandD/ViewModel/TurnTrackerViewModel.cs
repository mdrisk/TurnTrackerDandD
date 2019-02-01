using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TurnTrackerDandD.Models;

namespace TurnTrackerDandD.ViewModel
{
    class TurnTrackerViewModel
    {
        public TurnTrackerViewModel()
        {

        }

        private ObservableCollection<Combatant> combatants = new ObservableCollection<Combatant>();
        public ObservableCollection<Combatant> Combatants
        {
            get { return combatants; }
            set { combatants = value; }
        }

       


        public void PopulateTestData()
        {

            Random r = new Random();
            for (int i = 0; i < 6; i++)
            {

                int initiative = r.Next(0, 30);
                Combatant combatant = new Combatant
                {
                    Name = "Combatant" + i,
                    Initiative = initiative,
                    Banes = new List<string>() { "Hunters Mark +1d6 dmg" },
                    Boons = new List<string>() { "Inspiration +1d8 for attack or save" }
                };
                Combatants.Add(combatant);
            }

            Combatants.Sort(x => x.Initiative);

        }

        
    

    public void AddCombatant(string name, int initiative)
        {
            Combatant combatant = new Combatant { Name = name, Initiative = initiative };
            Combatants.Add(combatant);
            Combatants.Sort(x => x.Initiative);
            
            
        }
       


    }

    static class ExtraFunctions
    {
        public static void Sort<TSource, TKey>(this Collection<TSource> source, Func<TSource, TKey> keySelector)
        {
            List<TSource> sortedList = source.OrderByDescending(keySelector).ToList();
            source.Clear();
            foreach (var sortedItem in sortedList)
                source.Add(sortedItem);
        }
    }
}
