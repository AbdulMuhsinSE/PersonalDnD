using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThreeDs.Exception;

namespace ThreeDs.DataModel
{
    public class Vehicle : Item
    {
        int speed;
        double carryingCapacity;
        Armor armor;
        Item saddle;
        /*
         * def types are land, aquatic and flying.
         * DM may define new types. Aquatic & flying require
         * exotic saddles
         * */
        String mountType;
        Dictionary<Item, int> carriedItems;

        public Vehicle(string name, string description, int currency, int speed, double carryingCapacity, Armor armor, Item saddle, string mountType, Dictionary<Item, int> carriedItems)
            : base(name, description, currency)
        {
            double totalCarriedWeight = CalcCarriedItemWeight();
            if (totalCarriedWeight > carryingCapacity) { throw new OverBurdendException(); }
            this.speed = speed;
            this.carryingCapacity = carryingCapacity;
            this.armor = armor;
            this.saddle = saddle;
            this.mountType = mountType;
            this.carriedItems = carriedItems;
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public double CarryingCapacity
        {
            get
            {
                return carryingCapacity;
            }

            set
            {
                carryingCapacity = value;
            }
        }

        public Armor Armor
        {
            get
            {
                return armor;
            }

            set
            {
                armor = value;
            }
        }

        public Item Saddle
        {
            get
            {
                return saddle;
            }

            set
            {
                saddle = value;
            }
        }

        public string MountType
        {
            get
            {
                return mountType;
            }

            set
            {
                mountType = value;
            }
        }

        public Dictionary<Item, int> CarriedItems
        {
            get
            {
                return carriedItems;
            }

            set
            {
                carriedItems = value;
            }
        }

		public bool addItem(Item item)
		{
			double newWeight = CalcCarriedItemWeight() + item.Weight;
			if (newWeight >= carryingCapacity)
			{
				throw new OverBurdendException();
			}
			else
			{
				bool contains = this.CarriedItems.ContainsKey(item);
				if (contains)
				{
					this.CarriedItems[item]++;
				}
				else
				{
					this.CarriedItems.Add(item, 1);
				}
				return true;
			}
		}

        public double CalcCarriedItemWeight()
        {
            double totalCarriedWeight = 0;
            foreach (KeyValuePair<Item, int> entry in carriedItems)
            {
                totalCarriedWeight += (entry.Key.Weight * entry.Value);
            }
            return totalCarriedWeight;
        }
    }
}