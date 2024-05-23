using System.Windows;
using System.Windows.Controls;
using Wpf_Bank_A.Data;

namespace Wpf_Bank_A
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickEnter(object sender, RoutedEventArgs e)
        {
            if (SpecialistSelector.SelectedItem is ListBoxItem selectedListBoxItem &&
                selectedListBoxItem.Content != null)
            {
                string selectedValue = selectedListBoxItem.Content.ToString();
                ClientDisplay clientDisplay;

                if (selectedValue == "Менеджер")
                {
                    clientDisplay = new ClientDisplay(ModificationType.Менеджер);
                }
                else
                {
                    clientDisplay = new ClientDisplay(ModificationType.Консультант);
                }

                clientDisplay.Show();
                Close();
            }
        }
    }
}