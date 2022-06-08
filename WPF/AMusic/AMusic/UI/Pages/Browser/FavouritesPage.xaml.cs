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
    /// Логика взаимодействия для FavouritesPage.xaml
    /// </summary>
    public partial class FavouritesPage : Page
    {
        private int idOrderBy = 4;
        List<Albums> listAlbums;
        List<Tracks> listTracks;

        public FavouritesPage()
        {
            InitializeComponent();
            listAlbums = AMusicEntities.GetContext().Users.ToList().Find(u => u.ID_user == Properties.Settings.Default.CurrentUserID)
                .FeaturedAlbums.Select(fa => fa.Albums).ToList();
            listTracks = AMusicEntities.GetContext().Users.ToList().Find(u => u.ID_user == Properties.Settings.Default.CurrentUserID)
                .FeaturedTracks.Select(ft => ft.Tracks).ToList();
            UpdateFavouritesAlbums();
            UpdateFavouritesTracks();
        }


        private void UpdateFavouritesAlbums() {
            listAlbums.Reverse();
            lvFavouritesAlbums.ItemsSource = listAlbums;
        }
        
        private void UpdateFavouritesTracks() {
            //list.Reverse();

            switch (idOrderBy) {
                case 0:
                    listTracks = listTracks.OrderByDescending(l => l.title).ToList();
                    break;
                case 1:
                    listTracks = listTracks.OrderBy(l => l.title).ToList();
                    break;
                case 2:
                    listTracks = listTracks.OrderByDescending(l => l.albumTitle).ToList();
                    break;
                case 3:
                    listTracks = listTracks.OrderBy(l => l.albumTitle).ToList();
                    break;
                case 4:
                    listTracks = listTracks.OrderByDescending(l => l.whenAddedByCurrentUser).ToList();
                     break;
                case 5:
                    listTracks = listTracks.OrderBy(l => l.whenAddedByCurrentUser).ToList();
                    break;
                case 6:
                    listTracks = listTracks.OrderByDescending(l => l.duration).ToList();
                    break;
                case 7:
                    listTracks = listTracks.OrderBy(l => l.duration).ToList();
                    break;
            }

            for (int i = 0; i < listTracks.Count; i++) {
                listTracks[i].IdInList = i + 1;
            }
            lvFavouritesTracks.ItemsSource = listTracks;
            //MessageBox.Show(lvFavouritesTracks.Tag.ToString());
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

        private void btnFromHeaderTitle_Click(object sender, RoutedEventArgs e) { //  ▲  ▼  
            string text = btnFromHeaderTitle.Content.ToString();
            if (text == "Название ▼") {
                idOrderBy = 0;
                btnFromHeaderTitle.Content = "Название ▲";
            }
            else if (text == "Название ▲" || text == "Название") {
                idOrderBy = 1;
                btnFromHeaderTitle.Content = "Название ▼";
            }
            UpdateOtherButtons(1);
            UpdateFavouritesTracks();
        }

        private void btnFromHeaderAlbum_Click(object sender, RoutedEventArgs e) {
            string text = btnFromHeaderAlbum.Content.ToString();
            if (text == "Альбом ▼") {
                idOrderBy = 2;
                btnFromHeaderAlbum.Content = "Альбом ▲";
            }
            else if (text == "Альбом ▲" || text == "Альбом") {
                idOrderBy = 3;
                btnFromHeaderAlbum.Content = "Альбом ▼";
            }
            UpdateOtherButtons(2);
            UpdateFavouritesTracks();
        }

        private void btnFromHeaderWhenAdded_Click(object sender, RoutedEventArgs e) {
            string text = btnFromHeaderWhenAdded.Content.ToString();
            if (text == "Дата добавления ▼") {
                idOrderBy = 4;
                btnFromHeaderWhenAdded.Content = "Дата добавления ▲";
            }
            else if (text == "Дата добавления ▲" || text == "Дата добавления") {
                idOrderBy = 5;
                btnFromHeaderWhenAdded.Content = "Дата добавления ▼";
            }
            UpdateOtherButtons(3);
            UpdateFavouritesTracks();
        }

        private void btnFromHeaderDuration_Click(object sender, RoutedEventArgs e) {
            string text = btnFromHeaderDuration.Content.ToString();
            if (text == "Длительность ▼") {
                idOrderBy = 6;
                btnFromHeaderDuration.Content = "Длительность ▲";
            }
            else if (text == "Длительность ▲" || text == "Длительность") {
                idOrderBy = 7;
                btnFromHeaderDuration.Content = "Длительность ▼";
            }
            UpdateOtherButtons(4);
            UpdateFavouritesTracks();
        }

        private void UpdateOtherButtons(int buttonNumber) {
            if (buttonNumber != 1)
                btnFromHeaderTitle.Content = "Название";
            if (buttonNumber != 2)
                btnFromHeaderAlbum.Content = "Альбом";
            if (buttonNumber != 3)
                btnFromHeaderWhenAdded.Content = "Дата добавления";
            if (buttonNumber != 4)
                btnFromHeaderDuration.Content = "Длительность";
        }

        private void lvFavouritesAlbums_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Manager.OpenAlbum(lvFavouritesAlbums, lvFavouritesAlbums.SelectedIndex);
        }
    }
}
