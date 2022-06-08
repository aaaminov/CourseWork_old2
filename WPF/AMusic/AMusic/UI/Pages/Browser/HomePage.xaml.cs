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
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        private int countTaked = 10;

        public HomePage()
        {
            InitializeComponent();
            if (Properties.Settings.Default.CurrentUserID >= 0) {
                Properties.Settings.Default.LastListenedTrack1 = 1;
                Properties.Settings.Default.LastListenedTrack2 = 2;
                Properties.Settings.Default.LastListenedTrack3 = 3;
                Properties.Settings.Default.LastListenedTrack4 = 4;
                Properties.Settings.Default.LastListenedTrack5 = 5;
                spForLastListened.Visibility = Visibility.Visible;
                UpdateLastListenedTracks();
            }
            //MessageBox.Show(System.IO.Directory.GetCurrentDirectory());
            UpdateLatestAlbums();
            UpdateMostListenedTracks();
        }

        private void sv_Horizontal_PreviewMouseWheel(object sender, MouseWheelEventArgs e) {
            if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)) {
                ScrollViewer scrollviewer = (ScrollViewer)sender;
                if (e.Delta > 0) {
                    scrollviewer.LineLeft();
                    scrollviewer.LineLeft();
                }
                else {
                    scrollviewer.LineRight();
                    scrollviewer.LineRight();
                }
            }
            else {
                if (e.Delta > 0) {
                    svMain.LineUp();
                    svMain.LineUp();
                    svMain.LineUp();
                }
                else {
                    svMain.LineDown();
                    svMain.LineDown();
                    svMain.LineDown();
                }
            }
            e.Handled = true;
        }

        private void UpdateLastListenedTracks() {
            lvLastListenedTracks.ItemsSource = new List<Tracks>() {
                AMusicEntities.GetContext().Tracks.ToList().Find(t => t.ID_track == Properties.Settings.Default.LastListenedTrack1),
                AMusicEntities.GetContext().Tracks.ToList().Find(t => t.ID_track == Properties.Settings.Default.LastListenedTrack2),
                AMusicEntities.GetContext().Tracks.ToList().Find(t => t.ID_track == Properties.Settings.Default.LastListenedTrack3),
                AMusicEntities.GetContext().Tracks.ToList().Find(t => t.ID_track == Properties.Settings.Default.LastListenedTrack4),
                AMusicEntities.GetContext().Tracks.ToList().Find(t => t.ID_track == Properties.Settings.Default.LastListenedTrack5),
            };
        }

        private void UpdateLatestAlbums() {
            var list = AMusicEntities.GetContext().Albums.ToList().OrderByDescending(t => t.date_of_creation).ToList();
            lvLatestAlbums.ItemsSource = list.Take(countTaked);
        }

        private void UpdateMostListenedTracks() {
            var list = AMusicEntities.GetContext().Tracks.ToList().OrderByDescending(t => t.count_of_listenings).ToList();
            lvMostListenedTracks.ItemsSource = list.Take(countTaked);
        }

        private void lvLatestAlbums_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Manager.OpenAlbum(lvLatestAlbums, lvLatestAlbums.SelectedIndex);
        }

        private void lvMostListenedTracks_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            //Albums album = (sender as ListView).SelectedItem as Albums;
            //Manager.NavigateFrame(Manager.ManagerBrowserFrame, new AlbumPage(album));
        }
    }
}
