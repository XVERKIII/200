using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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

namespace Store.PageLogIn
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        private static Registration page = new Registration();
        private logAndPass registration = new logAndPass();
        public Registration()
        {
            InitializeComponent();
            DataContext = registration;
        }
        public static Registration GetRegistration() => page;
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (logReg.Text != string.Empty
                && passReg.Text != string.Empty
                && firstNameReg.Text != string.Empty
                && lastNameReg.Text != string.Empty
                && DataBaseEntities.GetEntities().logAndPass.
                Any(x => x.logIn != logReg.Text && x.pass != passReg.Text))

            {
                if (passReg.Text.Length < 8)
                {
                    MessageBox.Show("пароль должен быть больше 8 символов!");
                    tryPass.Foreground = Brushes.Red;
                    tryPass.Visibility = Visibility.Visible;
                    return;
                }
                else
                {
                    DataBaseEntities.GetEntities().logAndPass.Add(registration);
                    tryPass.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                MessageBox.Show("Заполните поля");
                return;
            }
            try
            {
                    DataBaseEntities.GetEntities().SaveChanges();
                    MessageBox.Show("Данные сохранены");
                    Manager.frameManager.Navigate(LogIn.GetPage());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()); 
            }
        }

        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
            Manager.frameManager.Navigate(LogIn.GetPage());
        }
    }
}
