using AMusic.Classes;
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

namespace AMusic.UI.Pages.Dialog {
    /// <summary>
    /// Логика взаимодействия для HelloPage.xaml
    /// </summary>
    public partial class HelloPage : Page {
        public HelloPage() {
            InitializeComponent();
            //try {
            //    while (true) {
            //        Manager.ManagerBrowserFrame.RemoveBackEntry();
            //    }
            //}
            //catch {
                
            //}
        }

        private void btnToRegisterPage_Click(object sender, RoutedEventArgs e) {
            Manager.ManagerContentDialogFrame.Navigate(new RegisterPage());
        }

        private void btnToLoginPage_Click(object sender, RoutedEventArgs e) {
            Manager.ManagerContentDialogFrame.Navigate(new LoginPage());
        }
    }
}
