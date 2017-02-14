using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainContainer.Utils;

namespace MainContainer.Exception
{
    public class Weapon:Item
    {
        /*
         * 0 --> ranged - simple
         * 1 --> melee - simple
         * 2 --> ranged - martial
         * 3 --> melee - martial
         * */
        int type;
        List<string> weaponclass;
        bool silvered;
        List<Features> enhancemnets;
        Tuple<int, int> range;
        DamageType damageType;
        Tuple<int, Dice> damageDice;
        Tuple<int, Dice> versatileDamageDice;
        int weight;
        bool usable;

        public int Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public List<string> Weaponclass
        {
            get
            {
                return weaponclass;
            }

        }

        public bool Silvered
        {
            get
            {
                return silvered;
            }

            set
            {
                silvered = value;
            }
        }

        public List<Features> Enhancemnets
        {
            get
            {
                return enhancemnets;
            }

            set
            {
                enhancemnets = value;
            }
        }

        public Tuple<int, int> Range
        {
            get
            {
                return range;
            }

            set
            {
                range = value;
            }
        }

        public DamageType DamageType
        {
            get
            {
                return damageType;
            }

            set
            {
                damageType = value;
            }
        }

        public Tuple<int, Dice> DamageDice
        {
            get
            {
                return damageDice;
            }

            set
            {
                damageDice = value;
            }
        }

        public Tuple<int, Dice> VersatileDamageDice
        {
            get
            {
                return versatileDamageDice;
            }

            set
            {
                versatileDamageDice = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public bool Usable
        {
            get
            {
                return usable;
            }

            set
            {
                usable = value;
            }
        }

        public Weapon(string name, string description, int currencyEquivalentValue,int type, List<string> weaponclass, bool silvered, List<Features> enhancemnets, Tuple<int, int> range, 
            DamageType damageType, Tuple<int, Dice> damageDice, Tuple<int, Dice> versatileDamageDice,
            int weight) : base(name,description,currencyEquivalentValue)
        {
            this.type = type;
            this.weaponclass = weaponclass;
            this.silvered = silvered;
            this.enhancemnets = enhancemnets;
            this.range = range;
            this.damageType = damageType;
            this.damageDice = damageDice;
            this.versatileDamageDice = versatileDamageDice;
            this.weight = weight;
            this.usable = true;
        }

        public void enchant(Features enchantment)
        {
            if (enhancemnets == null)
            {
                enhancemnets = new List<Features>();
            }
            enhancemnets.Add(enchantment);
        }


    }
}
