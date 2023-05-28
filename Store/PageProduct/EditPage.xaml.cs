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
    /// <summary>
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page, INotifyPropertyChanged
    {
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private static EditPage page = new EditPage();
        private product editItem = new product();
        private string _deliveryDate;

        public string DeliveryDate_
        {
            get { return _deliveryDate; }
            set { _deliveryDate = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public EditPage()
        {
            InitializeComponent();
            comboBox.ItemsSource = DataBaseEntities.GetEntities().typeOfProduct.ToList();
            
        }
        public EditPage(product item): this()
        {
            editItem = item;
            DataContext = editItem;
            comboBox.SelectedIndex = item.typeID - 1;
            
        }
        public static EditPage GetPage() => page;

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
                
                editItem.deliveryDate = date;
                editItem.typeID = DataBaseEntities.GetEntities().typeOfProduct.ToList().
                FirstOrDefault(x => x.typeProduct == comboBox.Text).id;
                try
                {
                    DataBaseEntities.GetEntities().SaveChanges();
                    Manager.frameManager.Navigate(ProductPage.GetPage());
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
