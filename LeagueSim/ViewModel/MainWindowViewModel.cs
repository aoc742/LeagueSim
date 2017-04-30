using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueSim.ViewModel
{
    class MainWindowViewModel : BaseViewModel
    {
        public SummonerViewModel CharacterViewModel { get; set; } = new SummonerViewModel();

        public VisualViewModel VisualList { get; set; } = new VisualViewModel();

    }
}
