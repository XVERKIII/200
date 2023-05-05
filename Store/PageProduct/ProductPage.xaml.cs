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

namespace Store.PageProduct
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        private static ProductPage page = new ProductPage();
        public ProductPage()
        {
            InitializeComponent();
            dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.ToString();
        }
        public static Page GetPage() => page;

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.GetWindow.Close();
        }
    }
}
