using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSim.ViewModel;

namespace LeagueSim.Model
{
    class CharacterModel : BaseViewModel
    {
        #region Members
        private int _attackDamage;
        private int _armor;
        private int _attackSpeed;
        private int _critical;
        private int _abilityPower;
        private int _magicResist;
        private int _cooldown;
        private int _movespeed;
        private double _healthRegen;
        private double _resourceRegen;
        private int _lethality;
        private int _magicPen;
        private bool _canChange;
        #endregion

        #region Properties
        public int AttackDamage
        {
            get
            {
                return this._attackDamage;
            }
            set
            {
                this._attackDamage = value;
                OnPropertyChanged(nameof(this.AttackDamage));
            }
        }
        public int Armor
        {
            get
            {
                return this._armor;
            }
            set
            {
                this._armor = value;
                OnPropertyChanged(nameof(this.Armor));
            }
        }
        public int AttackSpeed
        {
            get
            {
                return this._attackSpeed;
            }
            set
            {
                this._attackSpeed = value;
                OnPropertyChanged(nameof(this.AttackSpeed));
            }
        }
        public int Critical
        {
            get
            {
                return this._critical;
            }
            set
            {
                this._critical = value;
                OnPropertyChanged(nameof(this.Critical));
            }
        }
        public int AbilityPower
        {
            get
            {
                return this._abilityPower;
            }
            set
            {
                this._abilityPower = value;
                OnPropertyChanged(nameof(this.AbilityPower));
            }
        }
        public int MagicResist
        {
            get
            {
                return this._magicResist;
            }
            set
            {
                this._magicResist = value;
                OnPropertyChanged(nameof(this.MagicResist));
            }
        }
        public int Cooldown
        {
            get
            {
                return this._cooldown;
            }
            set
            {
                this._cooldown = value;
                OnPropertyChanged(nameof(this.Cooldown));
            }
        }
        public int Movespeed
        {
            get
            {
                return this._movespeed;
            }
            set
            {
                this._movespeed = Movespeed;
                OnPropertyChanged(nameof(this.Movespeed));
            }
        }
        #endregion

        public CharacterModel()
        {

        }
    }
}
