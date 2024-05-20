using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Bank_A
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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
                ClientDisplay clientDisplay = new ClientDisplay();

                if (selectedValue == "Менеджер")
                {
              //      clientViewPage.ModificationType = Data.ModificationType.Менеджер;
                }
                else
                {
                    //       clientViewPage.ModificationType = Data.ModificationType.Консультант;
                }
                clientDisplay.Show();
                Close();

            }
        }
    }
}