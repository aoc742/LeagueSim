using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;
using System.IO;
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

        private int _requestAmount = API.KeyRateLimit.requestsRemaining;
        public int RequestAmount
        {
            get
            {
                return this._requestAmount;
            }
            set
            {
                this._requestAmount = value;
                OnPropertyChanged(nameof(this.RequestAmount));
            }
        }

        private double _progress;
        public double Progress
        {
            get
            {
                return this._progress;
            }
            set
            {
                this._progress = value;
                OnPropertyChanged(nameof(this.Progress));
            }
        }

        private DelegateCommand _searchSummonerName;
        public DelegateCommand SearchSummonerName
        {
            get
            {
                return _searchSummonerName ?? (_searchSummonerName = new DelegateCommand(SearchSummonerCommand, started));
            }
        }

        public CharacterViewModel()
        {
        }

        public bool started(object obj)
        {
            ++RequestAmount;
            return true;
        }

        public void SearchSummonerCommand(object obj)
        {
            Progress = 0;
            Task<int> x = SearchSummonerNameCommand(obj);
        }

        public async Task<int> SearchSummonerNameCommand(object obj)
        {
            string filePath = "c:\\Users\\Austin\\Desktop\\testFile.txt";

            File.WriteAllText(filePath, "Classes for stats" + Environment.NewLine);

            int count = 0;
            int tempCount = 0;
            
            foreach (LeagueSim.Model.Champions champ1 in Enum.GetValues(typeof(LeagueSim.Model.Champions)))
            {
                foreach (LeagueSim.Model.Champions champ2 in Enum.GetValues(typeof(LeagueSim.Model.Champions)))
                {
                    if (string.Compare(champ1.ToString(), champ2.ToString()) == -1)
                    {
                        int textWriteCount = await Task.Run<int>(() =>
                        {
                            File.AppendAllText(filePath, "new ChampionComparison( " + champ1 + ", " + champ2 + ");" + Environment.NewLine);
                            Progress = (count + 1)*100/9180;
                            return tempCount;
                        });
                        count++;
                    }
                }
            }
            File.AppendAllText(filePath, "Total objects: " + count);

            return count;

            //API.KeyRateLimit.Request();
            //RequestAmount = API.KeyRateLimit.requestsRemaining;
        }

    }
}
