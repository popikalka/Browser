using System.ComponentModel;
using System.Runtime.CompilerServices;
using PersonalBrowser.Wpf.Model;
using PersonalBrowser.Core.Interfaces;
using PersonalBrowser.Wpf.Helper;
using AutoMapper;
using PersonalBrowser.Core.BusinessObjects;

namespace PersonalBrowser.Wpf.ViewModel
{
	class EditViewModel : INotifyPropertyChanged
	{
        private IDataBaseService _service;
        private LinkUi _link;

        public EditViewModel()
        {
            _service = ServiceProvider.Instance;
        }

        public LinkUi Link
		{
			get { return _link; }
			set
			{
                if (_link != value)
                {
                    _link = value;
                    OnPropertyChanged(nameof(Link));
                }
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged([CallerMemberName]string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}

        public bool AddLink()
        {
           return _service.AddLink(Mapper.Map<LinkUi, LinkDto>(Link));
        }

        public bool EditLink()
        {
            return _service.EditLink(Mapper.Map<LinkUi, LinkDto>(Link));
        }
    }
}
