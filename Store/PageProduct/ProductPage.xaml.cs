using System;
using System.Collections.Generic;
using System.Globalization;
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
    public class TypeIDConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, 
            object parameter, CultureInfo culture)
        {
            return DataBaseEntities.GetEntities().
                typeOfProduct.ToList().FirstOrDefault(x => x.id == (int)value).typeProduct;
        }

        public object ConvertBack(object value, Type targetType, 
            object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }

    public partial class ProductPage : Page
    {       
        private static ProductPage page = new ProductPage();
        public ProductPage()
        {
            InitializeComponent();
            dataGrid.ItemsSource = DataBaseEntities.GetEntities().products;

        }
        public static Page GetPage() => page;

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.GetWindow.Close();
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            DateTime.TryParse("1/20/2020", out DateTime parse);
            var data = sender as Button;
            var d = data.DataContext;
            Manager.frameManager.Navigate(new EditPage(d as product));
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.frameManager.Navigate(new AddPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            dataGrid.Items.Refresh();
        }

        private void delBtn_Click(object sender, RoutedEventArgs e)
        {
            var productRemove = dataGrid.SelectedItems.Cast<product>().ToList();
            if (MessageBox.Show($"Удалить следующие {productRemove.Count()} " +
                $"поставки?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    DataBaseEntities.GetEntities().product.RemoveRange(productRemove);
                    DataBaseEntities.GetEntities().SaveChanges();
                    MessageBox.Show("Поставки удалены");
                    dataGrid.ItemsSource = DataBaseEntities.GetEntities().products;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }             
        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.ToList();
        }

        private void Tools_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.
                Where(x => x.typeID == 1).ToList();
        }

        private void wallpaper_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.
                Where(x => x.typeID == 2).ToList();
        }

        private void tech_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.
                Where(x => x.typeID == 3).ToList();
        }

        private void mixture_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.
                Where(x => x.typeID == 4).ToList();
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            dataGrid.ItemsSource = DataBaseEntities.GetEntities().product.
                Where(x => x.nameProd == search.Text || x.nameProd.Contains(search.Text)).
                ToList();
        }
    }
}
