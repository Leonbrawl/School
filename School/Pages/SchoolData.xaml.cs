using School.Model;
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

namespace School.Pages
{
    /// <summary>
    /// Логика взаимодействия для SchoolData.xaml
    /// </summary>
    public partial class SchoolData : Page
    {
        public SchoolData()
        {
            InitializeComponent();
            DataGrid.ItemsSource = App.db.Dance.ToList();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = DataGrid.SelectedItem as Dance;
            selectedProduct.IsDelete = true;
            App.db.SaveChanges();
            ListView.ItemSource = App.db.Dance.Where(x => x.IsDelete != true).ToList();
        }
    }
}
