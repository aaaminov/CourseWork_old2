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

namespace AMusic.UI.Pages.Browser
{
    /// <summary>
    /// Логика взаимодействия для OptionsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
            spAccount.DataContext = 
                AMusicEntities.GetContext().Users.ToList().Find(u => u.ID_user == Properties.Settings.Default.CurrentUserID);
        }

        private void btnQuitAccount_Click(object sender, RoutedEventArgs e) {
            Properties.Settings.Default.CurrentUserID = -1;
            Properties.Settings.Default.Save();
            Manager.ManagerMainFrame.Navigate(new MainPage());
            Manager.ManagerDialogFrame.Navigate(new DialogPage("hello", null));
        }

        private void btnEditAccount_Click(object sender, RoutedEventArgs e) {

        }

        private void btnSupport_Click(object sender, RoutedEventArgs e) {

        }
    }
}
