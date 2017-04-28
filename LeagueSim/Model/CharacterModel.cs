using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSim.ViewModel;

namespace LeagueSim.Model
{
    public enum Champions
    {
        Aatrox,
        Ahri,
        Akali,
        Alistar,
        Amumu,
        Anivia,
        Annie,
        Ashe,
        AurelionSol,
        Azir,
        Bard,
        Blitzcrank,
        Brand,
        Braum,
        Caitlyn,
        Camille,
        Cassiopeia,
        ChoGath,
        Corki,
        Darius,
        Diana,
        DrMundo,
        Draven,
        Ekko,
        Elise,
        Evelynn,
        Ezreal,
        Fiddlesticks,
        Fiora,
        Fizz,
        Galio,
        Gangplank,
        Garen,
        Gnar,
        Gragas,
        Graves,
        Hecarim,
        Heimerdinger,
        Illaoi,
        Irelia,
        Ivern,
        Janna,
        JarvanIV,
        Jax,
        Jayce,
        Jhin,
        Jinx,
        Kalista,
        Karma,
        Karthus,
        Kassadin,
        Katarina,
        Kayle,
        Kennen,
        KhaZix,
        Kindred,
        Kled,
        KogMaw,
        LeBlanc,
        LeeSin,
        Leona,
        Lissandra,
        Lucian,
        Lulu,
        Lux,
        Malphite,
        Malzahar,
        Maokai,
        MasterYi,
        MissFortune,
        Mordekaiser,
        Morgana,
        Nami,
        Nasus,
        Nautilus,
        Nidalee,
        Nocturne,
        Nunu,
        Olaf,
        Orianna,
        Pantheon,
        Poppy,
        Quinn,
        Rammus,
        RekSai,
        Renekton,
        Rengar,
        Riven,
        Rumble,
        Ryze,
        Sejuani,
        Shaco,
        Shen,
        Shyvana,
        Singed,
        Sion,
        Sivir,
        Skarner,
        Sona,
        Soraka,
        Swain,
        Syndra,
        TahmKench,
        Taliyah,
        Talon,
        Taric,
        Teemo,
        Thresh,
        Tristana,
        Trundle,
        Tryndamere,
        TwistedFate,
        Twitch,
        Udyr,
        Urgot,
        Varus,
        Vayne,
        Veigar,
        VelKoz,
        Vi,
        Viktor,
        Vladimir,
        Volibear,
        Warwick,
        Wukong,
        Xerath,
        XinZhao,
        Yasuo,
        Yorick,
        Zac,
        Zed,
        Ziggs,
        Zilean,
        Zyra
    }

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
        public double HealthRegen
        {
            get
            {
                return this._healthRegen;
            }
            set
            {
                this._healthRegen = value;
                OnPropertyChanged(nameof(this.HealthRegen));
            }
        }
        public double ResourceRegen
        {
            get
            {
                return this._resourceRegen;
            }
            set
            {
                this._resourceRegen = value;
                OnPropertyChanged(nameof(this.ResourceRegen));
            }
        }
        #endregion

        public CharacterModel()
        {

        }
    }
}
