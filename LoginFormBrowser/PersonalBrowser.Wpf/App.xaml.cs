using PersonalBrowser.Wpf.ViewModel;
using System.Windows;
using System.Windows.Threading;
using NLog;

namespace PersonalBrowser.Wpf
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
	    private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
		public App()
	    {
		    DispatcherUnhandledException += Application_DispatcherUnhandledException;
	    }
		private void Application_Startup(object sender, StartupEventArgs e)
        {
            PersonalBrowser.Wpf.Helper.AutoMapperConfig.RegisterMap();
            PersonalBrowser.Core.Helper.AutoMapperConfig.RegisterMap();
            MainWindow mainWindow = new MainWindow();
            mainWindow.DataContext = new MainViewModel();
            mainWindow.Show();
        }
	    private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
	    {
		    _logger.Error(e.Exception.Message);
            MessageBox.Show(e.Exception.Message, "Personal Browser", MessageBoxButton.OK, MessageBoxImage.Error);
		    e.Handled = true;
	    }
	}
}
