using System.Windows;
using PersonalBrowser.Wpf.ViewModel;
using PersonalBrowser.Core.Interfaces;
using PersonalBrowser.Core.Services;
using PersonalBrowser.Wpf.Model;
using PersonalBrowser.Core.BusinessObjects;
using AutoMapper;

namespace PersonalBrowser.Wpf
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        private bool _isEmptyForm;

        public EditWindow(bool isEmptyForm)
        {
            InitializeComponent();
            _isEmptyForm = isEmptyForm;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (_isEmptyForm)
            {
                if (((EditViewModel)DataContext).AddLink())
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                    "Ошибка при сохраннии",
                    "Ошибка",
                   MessageBoxButton.OK,
                    MessageBoxImage.Error);
                }
            }
            else
            {
                if (((EditViewModel)DataContext).EditLink())
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                    "Ошибка при сохраннии",
                    "Ошибка",
                   MessageBoxButton.OK,
                    MessageBoxImage.Error);
                }
            }
        }
    }
}
