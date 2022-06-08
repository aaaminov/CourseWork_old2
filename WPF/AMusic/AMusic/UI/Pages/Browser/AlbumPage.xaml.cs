using AMusic.Classes.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

namespace AMusic.UI.Pages.Browser {
    /// <summary>
    /// Логика взаимодействия для AlbumPage.xaml
    /// </summary>
    public partial class AlbumPage : Page {
        private Albums album;

        public AlbumPage(Albums _album) {
            InitializeComponent();
            album = _album;
            imgForAlbumBlurColor.DataContext = album;
            gridForAlbum.DataContext = album;
            spForAlbum.DataContext = album;
            lvTracks.ItemsSource = album.Tracks.ToList();
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

        private void lvTracks_MouseEnter(object sender, MouseEventArgs e) {
            //((e.OriginalSource as ListViewItem).FindName("BtnMore") as Button).Visibility = Visibility.Visible;
        }

        private void lvTracks_MouseLeave(object sender, MouseEventArgs e) {
            //((e.OriginalSource as ListViewItem).FindName("BtnMore") as Button).Visibility = Visibility.Hidden;

        }
    }
}
