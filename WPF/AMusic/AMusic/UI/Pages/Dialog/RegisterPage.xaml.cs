using AMusic.Classes;
using AMusic.Classes.Models;
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
    /// Логика взаимодействия для RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page {
        private string email, password, passwordConfirm, name;
        private int id_user, id_country;

        public RegisterPage() {
            InitializeComponent();
            cmbCountries.ItemsSource = AMusicEntities.GetContext().Countries.Select(c => c.name).ToList();
        }

        private void TBxEmail_TextChanged(object sender, TextChangedEventArgs e) {
            email = TBxEmail.Text;
        }

        private void TBxPassword_TextChanged(object sender, TextChangedEventArgs e) {
            password = TBxPassword.Text;
        }

        private void TBxPasswordConfirm_TextChanged(object sender, TextChangedEventArgs e) {
            passwordConfirm = TBxPasswordConfirm.Text;
        }

        private void TBxName_TextChanged(object sender, TextChangedEventArgs e) {
            name = TBxName.Text;
        }

        private void cmbCountries_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            id_country = cmbCountries.SelectedIndex;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e) {
            Manager.ManagerContentDialogFrame.Navigate(new HelloPage());
            //Manager.ManagerContentDialogFrame.GoBack();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e) {
            if (IsEmailRight() && IsPasswordsRight() && cmbCountries.SelectedIndex != -1) {
                Users user = new Users {
                    status = 0,
                    login = TBxEmail.Text,
                    password = TBxPassword.Text,
                    name = TBxName.Text,
                    ID_country = cmbCountries.SelectedIndex + 1,
                };
                AMusicEntities.GetContext().Users.Add(user);
                AMusicEntities.GetContext().SaveChanges();
                Properties.Settings.Default.CurrentUserID = user.ID_user;
                Properties.Settings.Default.Save();
                Manager.CloseDialogPage();
            }
        }

        // a@b.c
        // 12345
        private bool IsEmailRight() {
            if (AMusicEntities.GetContext().Users.ToList().Find(u => u.login == email) != null) {
                return false;
            }
            if (!(email.Contains('@') && email.Contains('.'))){
                return false;
            }
            if (!(email.IndexOf('@') == email.LastIndexOf('@') && email.IndexOf('.') == email.LastIndexOf('.'))) {
                return false;
            }
            if (!(email.IndexOf('@') + 1 < email.IndexOf('.'))) {
                return false;
            }
            if (email.IndexOf('@') < 2 || email.IndexOf('.') < 4) {
                return false;
            }

            return true;
        }

        // helloworld123
        // 123456789
        private bool IsPasswordsRight() {
            if (!(password.Contains('1') || password.Contains('2') || password.Contains('3') || 
                password.Contains('4') || password.Contains('5') || password.Contains('6') || 
                password.Contains('7') || password.Contains('8') || password.Contains('9') || password.Contains('0'))){
                return false;
            }
            if (password.Length < 6) {
                return false;
            }
            if (password != passwordConfirm) {
                return false;
            }

            return true;
        }
    }
}
