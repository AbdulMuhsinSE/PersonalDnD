using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MainContainer.Exception
{
    public class Armor:Item
    {
        /*
         * 0 --> Light
         * 1 --> Medium
         * 2 --> Heavy
         * 3 --> Shield (Spc case)
         * This allows for custom types defined by dm. e.g. mount armor 
         * */
        int type;
        //dex modifier extrapolated from type. Custom types will default to 0
        int armorclass;
        int currentAC;
        bool usable;
        int strRequirement;
        bool stealthDisadvantage;
        // default in lbs.
        int weight;
        List<Features> bonus;

       
        public Armor( string name, string description, int currencyEquivalentValue, int type, int armorclass, int strRequirement,
            bool stealthDisadvantage, int weight, List<Features> bonus) : base(name, description, currencyEquivalentValue)
        {
            this.Name = name;
            this.Description = description;
            this.CurrencyEquivalentValue = currencyEquivalentValue;
            this.type = type;
            this.armorclass = armorclass;
            this.currentAC = armorclass;
            this.usable = true;
            this.strRequirement = strRequirement;
            this.stealthDisadvantage = stealthDisadvantage;
            this.weight = weight;
            this.bonus = bonus;
        }

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

        public int Armorclass
        {
            get
            {
                return armorclass;
            }

            set
            {
                armorclass = value;
            }
        }

        public int CurrentAC
        {
            get
            {
                return currentAC;
            }

            set
            {
                currentAC = value;
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

        public int StrRequirement
        {
            get
            {
                return strRequirement;
            }

            set
            {
                strRequirement = value;
            }
        }

        public bool StealthDisadvantage
        {
            get
            {
                return stealthDisadvantage;
            }

            set
            {
                stealthDisadvantage = value;
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

        public List<Features> Bonus
        {
            get
            {
                return bonus;
            }
        }

        public void enchant(Features enchantment)
        {
            if(bonus == null)
            {
                bonus = new List<Features>();
            }
            bonus.Add(enchantment);
        }

        public void damageArmor(int diff)
        {
            if (diff > this.currentAC)
            {
                this.usable = false;
                this.currentAC = 0;
            }
            else
            {
                this.currentAC -= diff;
            }
        }

        public void mend()
        {
            this.currentAC = this.armorclass;
        }

    }
}