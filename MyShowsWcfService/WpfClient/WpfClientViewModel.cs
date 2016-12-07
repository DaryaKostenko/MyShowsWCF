﻿using System.Collections.Generic;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using WpfClient.MyShowsServiceReference;
using GalaSoft.MvvmLight.CommandWpf;

namespace WpfClient
{
    public class WpfClientViewModel:ViewModelBase
    {
        MyShowsServiceClient client = new MyShowsServiceClient();

        private ICommand _searchById;
        private ICommand _searchByWord;
        private ICommand _searchByCountry;
        private ShowInfo _showId;
        private List<ShowModel> _showMod;
        private ShowInfo _showWord;

        public string QweryId { get; set; }
        public string QweryWord { get; set; }
        public string QweryCountry { get; set; }

        public ShowInfo ShowId
        {
            get { return _showId; }
            set
            {
                _showId = value;
                RaisePropertyChanged(() => ShowId);
            }
        }

        public ShowInfo ShowWord
        {
            get { return _showWord; }
            set
            {
                _showWord = value;
                RaisePropertyChanged(() => ShowWord);
            }
        }

        public List<ShowModel> ShowMod
        {
            get { return _showMod; }
            set
            {
                _showMod = value;
                RaisePropertyChanged(() => ShowMod);
            }
        }

        public ICommand SearchById
        {
            get
            {
                return _searchById ?? (_searchById = new RelayCommand(() =>
                {
                    ShowId = client.GetShowById(QweryId);
                }));
            }
        }

        public ICommand SearchByWord
        {
            get
            {
                return _searchByWord ?? (_searchByWord = new RelayCommand(() =>
                {
                    ShowWord = client.GetShowByWord(QweryWord);
                }));
            }
        }

        public ICommand SearchByCountry
        {
            get
            {
                return _searchByCountry ?? (_searchByCountry = new RelayCommand(() =>
                {
                    ShowMod = new List<ShowModel>((client.GetShowsByCountry(QweryCountry)));
                }));
            }
        }
    }
}
