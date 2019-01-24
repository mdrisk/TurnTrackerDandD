using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using TurnTrackerDandD.ViewModel;

namespace TurnTrackerDandD.Views
{
    /// <summary>
    /// Interaction logic for AddCombatantView.xaml
    /// </summary>
    public partial class AddCombatantView : UserControl
    {
        public AddCombatantView()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            ((TurnTrackerViewModel)this.DataContext).AddCombatant(combatantNameTB.Text, Convert.ToInt32(intiativeTB.Text));
        }
    }
}
