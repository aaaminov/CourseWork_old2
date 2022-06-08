using AMusic.Classes;
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

namespace AMusic.UI.Pages.Browser.ForAdminOrArtist {
    /// <summary>
    /// Логика взаимодействия для ArtistPanelPage.xaml
    /// </summary>
    public partial class AdminOrArtistPanelPage : Page {
        public AdminOrArtistPanelPage() {
            InitializeComponent();
        }

        private void AddAlbum_Click(object sender, RoutedEventArgs e) {
            Manager.NavigateFrame(Manager.ManagerBrowserFrame, new AddAlbumPage());
        }
    }
}
