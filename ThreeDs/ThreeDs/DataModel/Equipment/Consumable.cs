using System;
using ThreeDs.Utils;

namespace ThreeDs.DataModel
{
	public class Consumable : Item
    {
        NullableBoolean hpEffect;
		DieFormula hpEffectValue;


		public Consumable(string name, string description, int currencyEquivalentValue) : base(name, description, currencyEquivalentValue)
		{
			this.hpEffect = NullableBoolean.Null;
			hpEffectValue = null;
		}

		public Consumable(string name, string description, int CEV, double weight) : base(name, description, CEV, weight)
		{
			this.hpEffect = NullableBoolean.Null;
			hpEffectValue = null;
		}

		public Consumable(string name, string description, int CEV, double weight, NullableBoolean hpEffect, DieFormula HPEV) : base(name, description, CEV, weight)
		{
			this.hpEffect = hpEffect;
			this.hpEffectValue = HPEV;
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

		public DieFormula HpEffectValue
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


    }
}
