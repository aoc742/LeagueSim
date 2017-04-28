using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using LeagueSim.Command;


namespace LeagueSim.ViewModel
{
    public class CharacterViewModel : BaseViewModel
    {
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

        private DelegateCommand _q;
        public DelegateCommand Q
        {
            get
            {
                return _q ?? (_q = new DelegateCommand(QMethod));
            }
        }

        public CharacterViewModel()
        {
            Title = "HELLO";
        }

        public void QMethod(object obj)
        {
            MessageBox.Show("Q clicked");
        }

    }
}
