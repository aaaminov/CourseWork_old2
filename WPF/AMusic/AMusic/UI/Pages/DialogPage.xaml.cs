using AMusic.Classes;
using AMusic.Classes.Models;
using AMusic.UI.Pages.Dialog;
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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AMusic.UI.Pages
{
    /// <summary>
    /// Логика взаимодействия для DialogPage.xaml
    /// </summary>
    public partial class DialogPage : Page
    {
        public DialogPage(string page, object data)
        {
            InitializeComponent();
            Manager.ManagerContentDialogFrame = ContentDialogFrame;
            BlurBackground(true);
            switch (page) {
                case "hello":
                    Manager.ManagerContentDialogFrame.Navigate(new HelloPage());
                    break;
                case "track_info":
                    Manager.ManagerContentDialogFrame.Navigate(new TrackInfoPage(data as Tracks));
                    break;
                case "": // others

                    break;
            }
        }

        private void BlurBackground(bool set) {
            if (set) {
                DialogBackground.Background.Opacity = 0.6;
                BlurEffect blur = new BlurEffect();
                blur.Radius = 5;
                Manager.ManagerMainFrame.Effect = blur;
            }
            else {
                Manager.ManagerMainFrame.Effect = null;
                Manager.ManagerDialogFrame.Content = null;
                Manager.ManagerContentDialogFrame.Content = null;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BlurBackground(false);
            //Frames.ManagerDialogFrame.NavigationService.RemoveBackEntry();
        }
    }
}
