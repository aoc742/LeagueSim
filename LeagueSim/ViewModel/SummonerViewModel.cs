﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;
using System.IO;
using LeagueSim.Model;
using LeagueSim.Command;


namespace LeagueSim.ViewModel
{
    public class SummonerViewModel : BaseViewModel
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

        private string _testData;
        public string TestData
        {
            get
            {
                return this._testData;
            }
            set
            {
                this._testData = value;
                OnPropertyChanged(nameof(TestData));
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

        public SummonerViewModel()
        {
        }

        public bool started(object obj)
        {
            ++RequestAmount;
            return true;
        }

        public ObservableCollection<ChampionComparison> testList { get; set; } = new ObservableCollection<Model.ChampionComparison>();

        public ObservableCollection<ChampionComparison> newList { get; set; } = new ObservableCollection<ChampionComparison>();

        public void SearchSummonerCommand(object obj)
        {
            var json = new JSON();
            if (RequestAmount > -10)
            {
                RequestAmount = -100;
                ChampionComparison test = new ChampionComparison("Aatrox", "Ahri");
                testList.Add(new ChampionComparison("Volibear", "Ahri"));
                testList.Add(new ChampionComparison("Trundle", "Amumu"));
                var filePath = AppDomain.CurrentDomain.BaseDirectory + "ChampionComparisons.json";
                json.WriteToJsonFile<ObservableCollection<ChampionComparison>>(filePath, testList);
            }
            else
            {
                newList = json.ReadFromJsonFile<ObservableCollection<ChampionComparison>>("C:\\Users\\Austin\\Desktop\\test.json");
            }

            //Progress = 0;
            //Task<int> x = SearchSummonerNameCommand(obj);
        }

        public async Task<int> ConstructJsonConfiguration(object obj)
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "ChampionComparisons.json";
            ObservableCollection<ChampionComparison> ChampionComparisons = new ObservableCollection<ChampionComparison>();

            foreach (LeagueSim.Model.Champions champ1 in Enum.GetValues(typeof(LeagueSim.Model.Champions)))
            {
                ChampionComparisons.Add(new ChampionComparison(champ1.ToString(), champ1.ToString()));
            }

            return 0;
        }

        public async Task<int> SearchSummonerNameCommand(object obj)
        {
            string filePath = "c:\\Users\\Austin\\Desktop\\testFile.txt";

            File.WriteAllText(filePath, "Classes for stats" + Environment.NewLine);

            int count = 0;
            int tempCount = 0;
            
            foreach (LeagueSim.Model.Champions champ1 in Enum.GetValues(typeof(LeagueSim.Model.Champions)))
            {
                int textWriteCount = await Task.Run<int>(() =>
                {
                    File.AppendAllText(filePath, "[DataMember]\npublic string" + )
                })
                //foreach (LeagueSim.Model.Champions champ2 in Enum.GetValues(typeof(LeagueSim.Model.Champions)))
                //{
                //    if (string.Compare(champ1.ToString(), champ2.ToString()) == -1)
                //    {
                //        int textWriteCount = await Task.Run<int>(() =>
                //        {
                //            File.AppendAllText(filePath, "new ChampionComparison( " + champ1 + ", " + champ2 + ");" + Environment.NewLine);
                //            Progress = (count + 1)*100/9180;
                //            return tempCount;
                //        });
                //        count++;
                //    }
                //}
            }
            File.AppendAllText(filePath, "Total objects: " + count);

            return count;

            //API.KeyRateLimit.Request();
            //RequestAmount = API.KeyRateLimit.requestsRemaining;
        }

    }
}
