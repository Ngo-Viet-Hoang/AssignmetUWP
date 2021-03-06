using MusicApp.Entities;
using MusicApp.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MusicApp.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListSongPage : Page
    {
        private SongService songService = new SongService();
        public ListSongPage()
        {
            this.InitializeComponent();
            this.Loaded += LoadPost;
        }
        private async void LoadPost(object sender, RoutedEventArgs e)
        {
            var listSong = await songService.FindAll();
            ListData.ItemsSource = listSong;
        }
private void ListData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var song = ListData.SelectedItem as Song;
        }
    }
}



