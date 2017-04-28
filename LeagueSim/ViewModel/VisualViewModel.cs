using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace LeagueSim.ViewModel
{
    public class VisualViewModel : BaseViewModel
    {
        private ObservableCollection<string> _visualList = new ObservableCollection<string>();
        public ObservableCollection<string> VisualList
        {
            get
            {
                return this._visualList;
            }
            set
            {
                this._visualList = value;
                OnPropertyChanged(nameof(this.VisualList));
            }
        }

        public VisualViewModel()
        {
            
        }
    }
}
