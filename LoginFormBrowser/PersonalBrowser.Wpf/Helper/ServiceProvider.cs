using PersonalBrowser.Core.Interfaces;
using PersonalBrowser.Core.Services;

namespace PersonalBrowser.Wpf.Helper
{
    public class ServiceProvider
    {
        private static IDataBaseService instance;

        private ServiceProvider() { }

        public static IDataBaseService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataBaseService();
                }
                return instance;
            }
        }
    }
}
