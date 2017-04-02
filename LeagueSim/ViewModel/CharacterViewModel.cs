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

        private DelegateCommand _buttonCommand;
        public DelegateCommand ButtonCommand
        {
            get
            {
                return _buttonCommand ?? (_buttonCommand = new DelegateCommand(ButtonMethod));
            }
        }

        public CharacterViewModel()
        {
            Title = "HELLO";
        }

        public void ButtonMethod(object obj)
        {
            MessageBox.Show("Testing Button click");
        }

    }
}
