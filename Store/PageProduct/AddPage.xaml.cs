using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public partial class AddPage : Page
    {
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private static AddPage page = new AddPage();
        private product addItem = new product();
        private string _deliveryDate;

        public string DeliveryDate_
        {
            get { return _deliveryDate; }
            set { _deliveryDate = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public AddPage()
        {
            InitializeComponent();
            comboBox.ItemsSource = DataBaseEntities.GetEntities().typeOfProduct.ToList();
            DataContext = addItem;
        }

        public static AddPage GetPage() => page;

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Manager.frameManager.Navigate(ProductPage.GetPage());
        }

        private void btnAply_Click(object sender, RoutedEventArgs e)
        {
            if (NameProd.Text == string.Empty ||
                comboBox.SelectedItem == null ||
                Price.Text == string.Empty ||
                Quantity.Text == string.Empty
                )
            {
                MessageBox.Show("заполните поля");
                return;
            }
            else
            {
                if (!DateTime.TryParseExact(_DeliveryDate.Text, "dd/MM/yyyy", null,
                      System.Globalization.DateTimeStyles.None, out DateTime date))
                {

                    MessageBox.Show("Ошибка парсинга даты");
                    return;
                }
                addItem.deliveryDate = date;
                addItem.typeID = DataBaseEntities.GetEntities().typeOfProduct.ToList().FirstOrDefault(x=>x.typeProduct == comboBox.Text).id;
               
                DataBaseEntities.GetEntities().products.Add(addItem);
                try
                {
                    DataBaseEntities.GetEntities().SaveChanges();

                    Manager.frameManager.Navigate(ProductPage.GetPage());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}    
