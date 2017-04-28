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
        Rakan,
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
        Xayah,
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
        private int _attackDamage;

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
        
        #endregion

        public CharacterModel()
        {

        }
    }
}
