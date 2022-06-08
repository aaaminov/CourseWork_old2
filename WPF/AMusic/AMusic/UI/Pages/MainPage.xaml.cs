using AMusic.Classes;
using AMusic.Classes.Models;
using AMusic.UI.Pages.Browser;
using AMusic.UI.Pages.Browser.ForAdminOrArtist;
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

namespace AMusic.UI.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private List<Button> buttonsMenu = new List<Button>();

        public MainPage()
        {
            InitializeComponent();
            buttonsMenu.AddRange(new List<Button> { btnHome, btnSearch, btnFavourites, btnSettings, btnAdminOrArtistPanel });
            BrowserFrame.JournalOwnership = JournalOwnership.UsesParentJournal;
            BrowserFrame.JournalOwnership = JournalOwnership.Automatic;
            ////BrowserFrame.Content = null;
            Manager.ManagerBrowserFrame = BrowserFrame;
            //Manager.ManagerBrowserFrame.JournalOwnership = System.Windows.Navigation.JournalOwnership.OwnsJournal;
            //btnHome_Click(btnHome, new RoutedEventArgs());
            Manager.NavigateFrame(Manager.ManagerBrowserFrame, new HomePage()); //, "home"
            //Manager.ClickToButton(btnSearch);
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scrollviewer = (ScrollViewer)sender;
            if (e.Delta > 0)
                scrollviewer.LineLeft();
            else
                scrollviewer.LineRight();
            e.Handled = true;
        }

        private void sliderDuration_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void sliderDuration_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {

        }

        private void sliderDuration_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {

        }

        private void sliderVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }


        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {

        }


        private void btnMenu_Click(object sender, RoutedEventArgs e) {
            switch ((sender as Button).Name) {
                case "btnHome": {
                    if (Manager.ManagerBrowserFrame.Tag != "HomePage") {
                        Manager.NavigateFrame(Manager.ManagerBrowserFrame, new HomePage());
                        //UpdateButtonBackgroud(0);
                    }
                    break;
                }
                case "btnSearch": {
                    if (Manager.ManagerBrowserFrame.Tag != "SearchPage") {
                        Manager.NavigateFrame(Manager.ManagerBrowserFrame, new SearchPage());
                    }
                    break;
                }
                case "btnFavourites": {
                    if (Manager.ManagerBrowserFrame.Tag != "FavouritesPage") {
                        Manager.NavigateFrame(Manager.ManagerBrowserFrame, new FavouritesPage());
                    }
                    break;
                }
                case "btnSettings": {
                    if (Manager.ManagerBrowserFrame.Tag != "SettingsPage") {
                        Manager.NavigateFrame(Manager.ManagerBrowserFrame, new SettingsPage());
                    }
                    break;
                }
                case "btnAdminOrArtistPanel": {
                    if (Manager.ManagerBrowserFrame.Tag != "AdminOrArtistPanelPage") {
                        Manager.NavigateFrame(Manager.ManagerBrowserFrame, new AdminOrArtistPanelPage());
                    }
                    break;
                }
                //case "btn": {
                //    if (Manager.ManagerBrowserFrame.Tag != "") {
                //        Manager.NavigateFrame(Manager.ManagerBrowserFrame, new ());
                //    }
                //    break;
                //}
                default: {
                    break;
                }
            }
        }

        private void btnMenu_MouseEnter(object sender, MouseEventArgs e) {
            switch ((sender as Button).Name) {
                case "btnHome":
                    (((sender as Button).Content as Grid).FindName("TBxHome") as TextBlock).Foreground = (Brush)FindResource("text_foreground_1");
                    break;
                case "btnSearch":
                    (((sender as Button).Content as Grid).FindName("TBxSearch") as TextBlock).Foreground = (Brush)FindResource("text_foreground_1");
                    break;
                case "btnFavourites":
                    (((sender as Button).Content as Grid).FindName("TBxFavourites") as TextBlock).Foreground = (Brush)FindResource("text_foreground_1");
                    break;
                case "btnSettings":
                    (((sender as Button).Content as Grid).FindName("TBxSettings") as TextBlock).Foreground = (Brush)FindResource("text_foreground_1");
                    break;
                case "btnAdminOrArtistPanel":
                    (((sender as Button).Content as Grid).FindName("TBxAdminOrArtistPanel") as TextBlock).Foreground = (Brush)FindResource("text_foreground_1");
                    break;
            }
            
        }
        
        private void btnMenu_MouseLeave(object sender, MouseEventArgs e) {
            switch ((sender as Button).Name) {
                case "btnHome":
                    if (Manager.ManagerBrowserFrame.Tag == null || Manager.ManagerBrowserFrame.Tag.ToString() != "HomePage")
                        (((sender as Button).Content as Grid).FindName("TBxHome") as TextBlock).Foreground = (Brush)FindResource("text_foreground_2");
                    break;
                case "btnSearch":
                    if (Manager.ManagerBrowserFrame.Tag == null || Manager.ManagerBrowserFrame.Tag.ToString() != "SearchPage")
                        (((sender as Button).Content as Grid).FindName("TBxSearch") as TextBlock).Foreground = (Brush)FindResource("text_foreground_2");
                    break;
                case "btnFavourites":
                    if (Manager.ManagerBrowserFrame.Tag == null || Manager.ManagerBrowserFrame.Tag.ToString() != "FavouritesPage")
                        (((sender as Button).Content as Grid).FindName("TBxFavourites") as TextBlock).Foreground = (Brush)FindResource("text_foreground_2");
                    break;
                case "btnSettings":
                    if (Manager.ManagerBrowserFrame.Tag == null || Manager.ManagerBrowserFrame.Tag.ToString() != "SettingsPage")
                        (((sender as Button).Content as Grid).FindName("TBxSettings") as TextBlock).Foreground = (Brush)FindResource("text_foreground_2");
                    break;
                case "btnAdminOrArtistPanel":
                    if (Manager.ManagerBrowserFrame.Tag == null || Manager.ManagerBrowserFrame.Tag.ToString() != "AdminOrArtistPanelPage")
                        (((sender as Button).Content as Grid).FindName("TBxAdminOrArtistPanel") as TextBlock).Foreground = (Brush)FindResource("text_foreground_2");
                    break;
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e) {
            Manager.ManagerBrowserFrame.NavigationService.GoBack();
        }

        private void btnForward_Click(object sender, RoutedEventArgs e) {
            Manager.ManagerBrowserFrame.NavigationService.GoForward();
        }

        private void BrowserFrame_ContentRendered(object sender, EventArgs e) {
            //MessageBox.Show("content updated\n" +
            //    (Manager.ManagerBrowserFrame.Content as Page).Title + "\n" +
            //    BrowserFrame.NavigationService.CanGoBack.ToString() + "\n" +
            //    BrowserFrame.NavigationService.CanGoForward.ToString());
            btnBack.IsEnabled = Manager.ManagerBrowserFrame.NavigationService.CanGoBack;
            btnForward.IsEnabled = Manager.ManagerBrowserFrame.NavigationService.CanGoForward;
            Manager.ManagerBrowserFrame.Tag = (Manager.ManagerBrowserFrame.Content as Page).Title;
            
            //string[] tags = Manager.ManagerBrowserFrame.Tag.ToString().Split('-');

            string tag = Manager.ManagerBrowserFrame.Tag?.ToString();
            if (tag != "") {
                int index = -1;
                //switch (tag) {
                //    case "back":
                //        tag = (Manager.ManagerBrowserFrame.Content as Page).Title;
                //        break;
                //    case "forward":
                //        index = 1;
                //        break;
                //}
                switch (tag) {
                    case "HomePage":
                        index = 0;
                        Users loginedUser = AMusicEntities.GetContext().Users.ToList()
                            .Find(u => u.ID_user == Properties.Settings.Default.CurrentUserID);
                        if (loginedUser != null) {
                            if (loginedUser.status >= 1) {
                                spForDopPanel.Visibility = Visibility.Visible;
                                (((btnAdminOrArtistPanel as Button).Content as Grid).FindName("TBxAdminOrArtistPanel") as TextBlock).Text = "Панель артиста";
                            }
                            else if (loginedUser.status == -1) {
                                spForDopPanel.Visibility = Visibility.Visible;
                                (((btnAdminOrArtistPanel as Button).Content as Grid).FindName("TBxAdminOrArtistPanel") as TextBlock).Text = "Админ. панель";
                            }
                            else {
                                spForDopPanel.Visibility = Visibility.Collapsed;
                            }
                        }
                        else {
                            spForDopPanel.Visibility = Visibility.Collapsed;
                        }
                        break;
                    case "SearchPage":
                        index = 1;
                        break;
                    case "FavouritesPage":
                        index = 2;
                        break;
                    case "SettingsPage":
                        index = 3;
                        break;
                    case "AdminOrArtistPanelPage":
                        index = 4;
                        break;
                }
                for (int i = 0; i < buttonsMenu.Count; i++) {
                    if (i == index) {
                        buttonsMenu[i].Background = (Brush)FindResource("button_background_3");
                        btnMenu_MouseEnter(buttonsMenu[i], null);
                    }
                    else {
                        buttonsMenu[i].Background = (Brush)FindResource("button_background_4");
                        btnMenu_MouseLeave(buttonsMenu[i], null);
                    }
                }
            }

        }

    }
}
