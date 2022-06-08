using AMusic.Classes;
using AMusic.UI.Pages;
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
using System.Windows.Shapes;

namespace AMusic.UI.Windows
{
    /// <summary>
    /// Логика взаимодействия для AppWindow.xaml
    /// </summary>
    public partial class AppWindow : Window
    {
        public AppWindow()
        {
            InitializeComponent();
            Manager.ManagerMainFrame = MainFrame;
            Manager.ManagerDialogFrame = DialogFrame;

            Manager.ManagerMainFrame.Navigate(new MainPage());            
            if (Properties.Settings.Default.CurrentUserID == -1) {
                Manager.ManagerDialogFrame.Navigate(new DialogPage("hello", null));
            }

            this.WindowState = WindowState.Maximized;
        }
    }
}
