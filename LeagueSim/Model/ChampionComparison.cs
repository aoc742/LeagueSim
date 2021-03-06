﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LeagueSim.Model
{
    [DataContract]
    public class ChampionComparison
    {
        [DataMember]
        public string FirstChampion { get; set; }
        [DataMember]
        public string SecondChampion { get; set; }
        [DataMember]
        public int Wins { get; set; }
        [DataMember]
        public int Losses { get; set; }
        [DataMember]
        public int AllyWins { get; set; }
        [DataMember]
        public int AllyLosses { get; set; }

        public ChampionComparison()
        {

        }

        public ChampionComparison(string firstChampion, string secondChampion, bool didFirstChampionWin, bool isSecondChampAlly = false)
        {
            FirstChampion = firstChampion;
            SecondChampion = secondChampion;
            Wins = Losses = AllyWins = AllyLosses = 0;

            var Champion = 
        }
    }
}
