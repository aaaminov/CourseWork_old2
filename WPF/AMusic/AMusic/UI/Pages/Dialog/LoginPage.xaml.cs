using AMusic.Classes;
using AMusic.Classes.Models;
using AMusic.UI.Pages.Browser;
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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page {

        private string login, password;

        public LoginPage() {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e) {
            Manager.ManagerContentDialogFrame.Navigate(new HelloPage());
            //Manager.ManagerContentDialogFrame.GoBack();
        }

        private void TBxEmail_TextChanged(object sender, TextChangedEventArgs e) {

        }

        private void TBxPassword_TextChanged(object sender, TextChangedEventArgs e) {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e) {
            Users loginedUser = AMusicEntities.GetContext().Users.ToList()
                .Find(u => u.login == TBxEmail.Text && u.password == TBxPassword.Text);
            if (loginedUser != null) {
                //MessageBox.Show(loginedUser.ID_user.ToString());
                Properties.Settings.Default.CurrentUserID = loginedUser.ID_user;
                Properties.Settings.Default.Save();
                Manager.CloseDialogPage();
                Manager.NavigateFrame(Manager.ManagerBrowserFrame, new HomePage());

                Manager.ManagerBrowserFrame.JournalOwnership = JournalOwnership.OwnsJournal;
                while (Manager.ManagerBrowserFrame.NavigationService.CanGoBack) {
                    Manager.ManagerBrowserFrame.NavigationService.RemoveBackEntry();
                }
                Manager.ManagerBrowserFrame.JournalOwnership = JournalOwnership.Automatic;
            }
            else {
                MessageBox.Show("неверный логин или пароль");
            }
        }
    }
}
