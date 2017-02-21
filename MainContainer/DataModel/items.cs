using System;

namespace MainContainer.DataModel
{
    public class DeprecatedItems
    {
        string name;
        string description;
        bool consumable;
        NullableBoolean hpEffect;
        int hpEffectValue;
        int val; // val of 0 means the item cannot be sold. val of 1 = 1cp

        public DeprecatedItems(string name, string description)
        {
            this.name = name;
            this.description = description;
            this.consumable = false;
            this.hpEffect = NullableBoolean.Null;
            this.val = 0;
            this.hpEffectValue = 0;
        }

        public DeprecatedItems(string name, string description, bool consumable, NullableBoolean hpEffect, int hpEffectValue, int val)
        {
            this.name = name;
            this.description = description;
            this.consumable = consumable;
            this.hpEffect = hpEffect;
            this.hpEffectValue = hpEffectValue;
            this.val = val;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public bool Consumable
        {
            get
            {
                return consumable;
            }

            set
            {
                consumable = value;
            }
        }

        public NullableBoolean HpEffect
        {
            get
            {
                return hpEffect;
            }

            set
            {
                hpEffect = value;
            }
        }

        public int HpEffectValue
        {
            get
            {
                return hpEffectValue;
            }

            set
            {
                hpEffectValue = value;
            }
        }

        public int Val
        {
            get
            {
                return val;
            }

            set
            {
                val = value;
            }
        }
    }
}
