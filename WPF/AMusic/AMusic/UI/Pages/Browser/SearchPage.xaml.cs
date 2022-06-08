using AMusic.Classes;
using AMusic.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Page
    {
        List<Albums> listAlbums;
        List<Tracks> listTracks;

        public SearchPage() {
            InitializeComponent();
            UpdateTopGenres();
        }

        private void UpdateTopGenres() {
            lvTopGenres.ItemsSource = AMusicEntities.GetContext().Genres.ToList().Skip(1).ToList();
            //lvTopGenres2.ItemsSource = AMusicEntities.GetContext().Genres.ToList().Skip(1).ToList();
        }

        //private void sv_Vertical_PreviewMouseWheel(object sender, MouseWheelEventArgs e) {
        //    if (!(Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))) {
        //        if (e.Delta > 0) {
        //            svMain.LineUp();
        //            svMain.LineUp();
        //            svMain.LineUp();
        //        }
        //        else {
        //            svMain.LineDown();
        //            svMain.LineDown();
        //            svMain.LineDown();
        //        }
        //    }
        //    e.Handled = true;
        //}

        //private void svMain_ScrollChanged(object sender, ScrollChangedEventArgs e) {
        //    int offset = (int) svMain.VerticalOffset;
        //    if (offset <= 32) {
        //        TBxSearch.Text = ((100d * offset) / 32d).ToString();
        //        gridSearch.Opacity = (100d * offset) / 32d;
        //    }
        //}

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

        private void TBxSearch_TextChanged(object sender, TextChangedEventArgs e) {
            if (TBxSearch.Text.Length >= 1) {
                TBkSearchPlaceholder.Visibility = Visibility.Collapsed;
            } else {
                TBkSearchPlaceholder.Visibility = Visibility.Visible;
            }

            string text = TBxSearch.Text.ToLower().Trim(new char[] { ' ', ',' });
            if (text.Length >= 1) {
                listAlbums = AMusicEntities.GetContext().Albums.ToList().Where(a =>
                    a.title.ToLower().Contains(text) ||
                    (a.description ?? "").ToLower().Contains(text) ||
                    a.artists.ToLower().Contains(text)
                ).OrderByDescending(a => a.totalCountOfListenings).ToList();
                listTracks = AMusicEntities.GetContext().Tracks.ToList().Where(t => 
                    t.title.ToLower().Contains(text) || 
                    t.artists.ToLower().Contains(text)
                ).OrderByDescending(t => t.count_of_listenings).ToList();
                TBxForNullResult.Visibility = Visibility.Collapsed;
                if (listAlbums.Count >= 1) {
                    spForFindedAlbums.Visibility = Visibility.Visible;
                    lvFindedAlbums.ItemsSource = listAlbums;
                }
                else {
                    spForFindedAlbums.Visibility = Visibility.Collapsed;
                }
                if (listTracks.Count >= 1) {
                    spForFindedTracks.Visibility = Visibility.Visible;
                    lvFindedTracks.ItemsSource = listTracks;
                }
                else {
                    spForFindedTracks.Visibility = Visibility.Collapsed;
                }
                if (!spForFindedAlbums.IsVisible && !spForFindedTracks.IsVisible) {
                    TBxForNullResult.Visibility = Visibility.Visible;
                }
            }
            else {
                spForFindedAlbums.Visibility = Visibility.Collapsed;
                spForFindedTracks.Visibility = Visibility.Collapsed;
            }
        }

        private void lvFindedAlbums_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Manager.OpenAlbum(lvFindedAlbums, lvFindedAlbums.SelectedIndex);
        }

        private void TBkSearchPlaceholder_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            TBxSearch.Focus();
        }

        private void lvTopGenres_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (lvTopGenres.SelectedIndex >= 0) {
                Manager.NavigateFrame(Manager.ManagerBrowserFrame, new GenrePage(lvTopGenres.SelectedItem as Genres));
                lvTopGenres.SelectedIndex = -1;
            }
        }
    }
}
