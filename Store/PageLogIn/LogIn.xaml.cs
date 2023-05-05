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

namespace Store.PageLogIn
{
    /// <summary>
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        private static LogIn page = new LogIn();
        public LogIn()
        {
            InitializeComponent();
        }
        public static Page GetPage() => page;

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            
            if (log.Text == string.Empty && pass.Text == string.Empty)
            {
                MessageBox.Show("Введите логин и пароль");
            }
            //проверка на текст в текстбоксе и базой логинИпароль это таблица
            else if (DataBaseEntities.GetEntities().logAndPass.Any(x=>x.logIn == log.Text && x.pass == pass.Text))
            {
                Manager.frameManager.Navigate(PageProduct.ProductPage.GetPage());
            }
            else
                MessageBox.Show("Неверные данные");
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            Manager.frameManager.Navigate(PageLogIn.Registration.GetRegistration());
        }
    }
}
