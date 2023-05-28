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

namespace Store
{
    public partial class MainWindow : Window
    {
        
        public static MainWindow GetWindow { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            GetWindow = this;
            Manager.frameManager = mainFrame;
            //mainFrame.Navigate(PageLogIn.LogIn.GetPage());
            mainFrame.Navigate(PageProduct.ProductPage.GetPage());
        }
    }
}
