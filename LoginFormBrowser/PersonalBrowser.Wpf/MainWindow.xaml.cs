using System.Linq;
using PersonalBrowser.Wpf.ViewModel;
using System.Windows;
using PersonalBrowser.Wpf.Model;
using System;
using System.Windows.Input;

namespace PersonalBrowser.Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadUser_Click(object sender, RoutedEventArgs e)
        {
            if (!((MainViewModel)DataContext).GetUser())
            {
                MessageBox.Show(
                    "Данное имя не зарегестрировано",
                    "Ошибка при вводе имени",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private void ChangeCurrentSite(object sender, RoutedEventArgs e)
        {
            Prev.IsEnabled = true;
            MainViewModel model = (MainViewModel)DataContext;
            if (model.Links != null && ListLinks.SelectedItem != null)
            {
                ((MainViewModel)DataContext).CurrentSite = model.Links.First(x => x.Title == (string)ListLinks.SelectedItem);
            }
        }

        private void App_Stop(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void App_Logout(object sender, RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
        }

        private void App_Add(object sender, RoutedEventArgs e)
        {
            MainViewModel model = (MainViewModel)DataContext;
            EditWindow window = new EditWindow(true);
            window.DataContext = new EditViewModel
            {
                Link = new LinkUi
                {
                    UserId = model.UserId
                }
            };
            window.ShowDialog();
            if (((EditViewModel)window.DataContext).Link != null)
            {
                ((MainViewModel)DataContext).GetUser();
            }
        }

        private void App_Edit(object sender, RoutedEventArgs e)
        {
            MainViewModel model = (MainViewModel)DataContext;
            EditWindow window = new EditWindow(false);
            window.DataContext = new EditViewModel
            {
                Link = model.SelectedLink
            };
            window.ShowDialog();
            if (((EditViewModel)window.DataContext).Link != null)
            {
                ((MainViewModel)DataContext).GetUser();
            }
        }

        private void App_Del(object sender, RoutedEventArgs e)
        {
            ((MainViewModel)DataContext).DeleteLink();
        }

        private void ListLinks_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            MainViewModel model = (MainViewModel)DataContext;
            if (model.Links != null && ListLinks.SelectedItem != null)
            {
                ((MainViewModel)DataContext).SelectedLink = model.Links.First(x => x.Title == (string)ListLinks.SelectedItem);
            }
        }

        private void PrevPage(object sender, RoutedEventArgs e)
        {
            if (Browser.CanGoBack)
            {
                Browser.GoBack();
                Next.IsEnabled = true;
            }
            else
            {
                Prev.IsEnabled = false;
            }
        }

        private void NextPage(object sender, RoutedEventArgs e)
        {
            if (Browser.CanGoForward)
            {
                Browser.GoForward();
                Prev.IsEnabled = true;
            }
            else
            {
                Next.IsEnabled = false;
            }
        }

        private void Reload(object sender, RoutedEventArgs e)
        {
            Browser.Refresh();
        }

        private void Url_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LinkUi link = new LinkUi { Address = new Uri(UrlBox.Text) };
                ((MainViewModel)DataContext).CurrentSite = link;
                Prev.IsEnabled = true;
            }
        }
    }
}
