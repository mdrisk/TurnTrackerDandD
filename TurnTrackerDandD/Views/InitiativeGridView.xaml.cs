using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TurnTrackerDandD.Models;

namespace TurnTrackerDandD.Views
{
    /// <summary>
    /// Interaction logic for InitiativeGridView.xaml
    /// </summary>
    public partial class InitiativeGridView : UserControl
    {
        
        public ObservableCollection<Combatant> CombatantList
        {
            get { return (ObservableCollection<Combatant>)GetValue(CombatantListProperty); }
            set { SetValue(CombatantListProperty, value); }
        }
        public static readonly DependencyProperty CombatantListProperty = 
            DependencyProperty.Register("CombatantList", 
                typeof(ObservableCollection<Combatant>), 
                typeof(InitiativeGridView), 
                new PropertyMetadata(new ObservableCollection<Combatant>(), new PropertyChangedCallback(OnValueChanged)));

        private static void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            InitiativeGridView igv = (InitiativeGridView)sender;
            igv.CombatantList = (ObservableCollection<Combatant>)e.NewValue;
            igv.PopulateCombatants();
           
        }

        public InitiativeGridView()
        {
            InitializeComponent();
            
        }

        public void PopulateCombatants()
        {
            int i = 0;
            foreach(Combatant combatant in CombatantList)
            {
                Label rollLabel = new Label() { Content = "Initiative: " };
                Label roll = new Label() { Content = combatant.Initiative };
                Label nameLabel = new Label() { Content = "Name: " };
                Label name = new Label() { Content = combatant.Name };
                Label banesLabel = new Label() { Content = "Banes: " };

                StackPanel banes = new StackPanel() { Orientation = Orientation.Horizontal };

                if(i == 2 || i == 4)
                banes.Children.Add(new Image() { Source = new BitmapImage(new Uri("../Media/icon1.PNG", UriKind.Relative) ) } );
                

                RowDefinition rd = new RowDefinition();
                rd.Height = GridLength.Auto;
                CombatantGrid.RowDefinitions.Add(rd);

                Grid.SetColumn(rollLabel, 0);
                Grid.SetColumn(roll, 1);
                Grid.SetColumn(nameLabel, 2);
                Grid.SetColumn(name, 3);
                Grid.SetColumn(banesLabel, 4);
                Grid.SetColumn(banes, 5);

                Grid.SetRow(rollLabel, i);
                Grid.SetRow(roll, i);
                Grid.SetRow(nameLabel, i);
                Grid.SetRow(name, i);
                Grid.SetRow(banes, i);
                Grid.SetRow(banesLabel, i);

                CombatantGrid.Children.Add(rollLabel);
                CombatantGrid.Children.Add(roll);
                CombatantGrid.Children.Add(nameLabel);
                CombatantGrid.Children.Add(name);
                CombatantGrid.Children.Add(banes);
                CombatantGrid.Children.Add(banesLabel);

                i++;
            }
        }
    }
}
