using AutoMapper;
using PersonalBrowser.Core.BusinessObjects;
using PersonalBrowser.Core.Interfaces;
using PersonalBrowser.Wpf.Helper;
using PersonalBrowser.Wpf.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PersonalBrowser.Wpf.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private int _userId;
        private string _userName;
        private List<LinkUi> _links;
        private LinkUi _selectedLink;
        private LinkUi _currSite;
        private IDataBaseService _service;

        public MainViewModel()
        {
            _service = ServiceProvider.Instance;
        }

        public int UserId
        {
            get { return _userId; }
            set
            {
                if (_userId != value)
                {
                    _userId = value;
                    OnPropertyChanged(nameof(UserId));
                }
            }
        }

        public string UserName
        {
            get { return _userName; }
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    OnPropertyChanged(nameof(UserName));
                }
            }
        }

        public List<LinkUi> Links
        {
            get { return _links; }
            set
            {
                if (_links != value)
                {
                    _links = value;
                    OnPropertyChanged(nameof(Links));
                }
            }
        }

        public LinkUi SelectedLink
        {
            get { return _selectedLink; }
            set
            {
                if(_selectedLink != value)
                {
                    _selectedLink = value;
                    OnPropertyChanged(nameof(SelectedLink));
                }

            }
        }

        public LinkUi CurrentSite
        {
            get { return _currSite; }
            set
            {
                if (_currSite != value)
                {
                    _currSite = value;
                    OnPropertyChanged(nameof(CurrentSite));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public bool GetUser()
        {
            UserDto user = _service.GetUser(UserName);
            if (user != null)
            {
                UserId = user.Id;
                Links = Mapper.Map<List<LinkDto>, List<LinkUi>>(user.Links);
                return true;
            }
            return false;
        }

        public bool DeleteLink()
        {
            if (SelectedLink != null)
            {
                if (_service.DeleteLink(Mapper.Map<LinkUi, LinkDto>(SelectedLink)))
                {
                    GetUser();
                    SelectedLink = null;
                    return true;
                }
            }
            return false;
        }
    }
}
