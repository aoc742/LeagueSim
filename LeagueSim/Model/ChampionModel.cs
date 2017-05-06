using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSim.ViewModel;
using System.Collections.ObjectModel;

namespace LeagueSim.Model
{
    public class ChampionModel : BaseViewModel
    {
        public string Name { get; protected set; }

        public ChampionModel(string name)
        {
            Name = name;
        }
    }
}
