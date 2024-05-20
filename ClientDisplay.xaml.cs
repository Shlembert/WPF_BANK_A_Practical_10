using System.Windows;
using System.Windows.Controls;
using Wpf_Bank_A.Data;

namespace Wpf_Bank_A
{
    public partial class ClientDisplay : Window
    {
        public ClientDisplay()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LoadClientsToTable(object sender, RoutedEventArgs e)
        {
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "data.json");
            ClientMaker clientMaker = new(filePath);
            TableClients.ItemsSource = clientMaker.LoadClients();
        }

        private void TableClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
