using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueSim.ViewModel
{
    class MainWindowViewModel : BaseViewModel
    {
        public CharacterViewModel CharacterViewModel { get; set; } = new CharacterViewModel();

        public VisualViewModel VisualList { get; set; } = new VisualViewModel();

    }
}
