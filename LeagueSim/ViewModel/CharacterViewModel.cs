using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;
using LeagueSim.Command;


namespace LeagueSim.ViewModel
{
    public class CharacterViewModel : BaseViewModel
    {
        public ObservableCollection<string> Regions { get; set; } = new ObservableCollection<string>()
        {
            "NA",
            "EUW",
            "KR"
        };

        private string _selectedRegion;
        public string SelectedRegion
        {
            get
            {
                return this._selectedRegion;
            }
            set
            {
                this._selectedRegion = value;
                OnPropertyChanged(nameof(this.SelectedRegion));
            }
        }

        public string _summonerName;
        public string SummonerName
        {
            get
            {
                return this._summonerName;
            }
            set
            {
                this._summonerName = value;
                OnPropertyChanged(nameof(this.SummonerName));
            }
        }

        private string _title;
        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
                OnPropertyChanged(nameof(this.Title));
            }
        }

        private DelegateCommand _searchSummonerName;
        public DelegateCommand SearchSummonerName
        {
            get
            {
                return _searchSummonerName ?? (_searchSummonerName = new DelegateCommand(SearchSummonerNameCommand));
            }
        }

        public CharacterViewModel()
        {
        }

        public void SearchSummonerNameCommand(object obj)
        {
            MessageBox.Show("Command");
        }

    }
}
