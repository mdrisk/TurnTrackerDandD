using System;
using System.Collections.Generic;
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

namespace TurnTrackerDandD.Views
{
    /// <summary>
    /// Interaction logic for InitiativeListView.xaml
    /// </summary>
    public partial class InitiativeListView : UserControl
    {
        public InitiativeListView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.combatButton.Content = "Next";
            if (this.IntitiativeList.SelectedIndex < this.IntitiativeList.Items.Count-1)
            {
                this.IntitiativeList.SelectedIndex = this.IntitiativeList.SelectedIndex + 1;
            }
            else
            {
                this.IntitiativeList.SelectedIndex = 0;   
            }
        }
    }
}
