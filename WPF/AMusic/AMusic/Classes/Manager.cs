using AMusic.Classes.Models;
using AMusic.UI.Pages.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AMusic.Classes
{
    internal class Manager
    {
        public static Frame ManagerMainFrame { get; set; }
        public static Frame ManagerDialogFrame { get; set; }

        public static Frame ManagerBrowserFrame { get; set; }

        public static Frame ManagerContentDialogFrame { get; set; }

        public static void NavigateFrame(Frame frame, Page page) { //, string tag
            frame.NavigationService.Navigate(page);
            //frame.Tag = tag;
        }

        public static void ClickToButton(Button btn) {
            btn.RaiseEvent(new RoutedEventArgs(Button.MouseDoubleClickEvent));
        }
        
        public static void OpenDialogPage() {
            ManagerMainFrame.Effect = null;
            ManagerDialogFrame.Content = null;
            ManagerContentDialogFrame.Content = null;
        }
        
        public static void CloseDialogPage() {
            ManagerMainFrame.Effect = null;
            ManagerDialogFrame.Content = null;
            ManagerContentDialogFrame.Content = null;
        }

        public static void OpenAlbum(ListView lv, int selectedIndex) {
            if (selectedIndex >= 0) {
                Albums album = (lv as ListView).SelectedItem as Albums;
                Manager.NavigateFrame(Manager.ManagerBrowserFrame, new AlbumPage(album));
                lv.SelectedIndex = -1;
            }
        }

    }
}
