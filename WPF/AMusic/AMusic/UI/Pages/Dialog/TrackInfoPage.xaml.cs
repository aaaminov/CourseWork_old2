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
    /// Логика взаимодействия для TrackInfoPage.xaml
    /// </summary>
    public partial class TrackInfoPage : Page {
        public TrackInfoPage(Tracks track) {
            InitializeComponent();
            track.lyrics = (track.lyrics ?? "Текст отсутствует").Replace("<br>", "\n");
            gridInfo.DataContext = track;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e) {
            Manager.CloseDialogPage();
        }

        private void sv_Horizontal_PreviewMouseWheel(object sender, MouseWheelEventArgs e) {
            ScrollViewer scrollviewer = (ScrollViewer)sender;
            if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)) {
                if (e.Delta > 0) {
                    scrollviewer.LineLeft();
                    scrollviewer.LineLeft();
                } else {
                    scrollviewer.LineRight();
                    scrollviewer.LineRight();
                }
            } else {
                if (e.Delta > 0) {
                    scrollviewer.LineUp();
                    scrollviewer.LineUp();
                    scrollviewer.LineUp();
                } else {
                    scrollviewer.LineDown();
                    scrollviewer.LineDown();
                    scrollviewer.LineDown();
                }
            }
            e.Handled = true;
        }

    }
}
