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

namespace AMusic.UI.Pages.Browser {
    /// <summary>
    /// Логика взаимодействия для GenrePage.xaml
    /// </summary>
    public partial class GenrePage : Page {
        private Genres genre;
        List<Albums> listAlbums;
        List<Tracks> listTracks;

        public GenrePage(Genres _genre) {
            InitializeComponent();
            genre = _genre;
            listAlbums = AMusicEntities.GetContext().Albums.ToList().Where(a => a.listTracksGenres.Contains(genre))
                .OrderByDescending(a => a.totalCountOfListenings).ToList();
            listTracks = AMusicEntities.GetContext().Tracks.ToList().Where(t => t.Genres.ID_genre == genre.ID_genre)
                .OrderByDescending(t => t.count_of_listenings).ToList();

            TbkGenre.DataContext = genre; 
            if (listAlbums.Count >= 1) {
                spForAlbums.Visibility = Visibility.Visible;
                lvAlbums.ItemsSource = listAlbums;
            }
            if (listTracks.Count >= 1) {
                spForTracks.Visibility = Visibility.Visible;
                lvTracks.ItemsSource = listTracks;
            }
            
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

        private void lvAlbums_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Manager.OpenAlbum(lvAlbums, lvAlbums.SelectedIndex);
        }


    }
}
