using AMusic.Classes;
using AMusic.Classes.Models;
using AMusic.UI.Pages;
using AMusic.UI.Pages.Browser;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AMusic
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void BtnMore_Click(object sender, RoutedEventArgs e) {
            Button btn = sender as Button;
            Grid grid = (btn.Parent as Grid);
            grid.ContextMenu.PlacementTarget = grid;
            grid.ContextMenu.IsOpen = true;
        }

        private void Track_Grid_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e) {
            Button btn = ((sender as Grid).FindName("BtnMore") as Button);
            if (btn.Visibility == Visibility.Hidden) {
                btn.Visibility = Visibility.Visible;
            }
        }

        private void Track_Grid_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e) {
            Button btn = ((sender as Grid).FindName("BtnMore") as Button);
            if (btn.Visibility == Visibility.Visible) {
                btn.Visibility = Visibility.Hidden;
            }
        }

        private void ToAlbum(object sender, RoutedEventArgs e) {
            Grid grid = ((sender as MenuItem).Parent as ContextMenu).PlacementTarget as Grid;
            Tracks track = grid.DataContext as Tracks;
            Manager.NavigateFrame(Manager.ManagerBrowserFrame, new AlbumPage(track.Albums));
            MessageBox.Show("1");
        }

        private void ToInfo(object sender, RoutedEventArgs e) {
            Grid grid = ((sender as MenuItem).Parent as ContextMenu).PlacementTarget as Grid;
            Tracks track = grid.DataContext as Tracks;
            Manager.ManagerDialogFrame.Navigate(new DialogPage("track_info", track));
        }
    }
}
