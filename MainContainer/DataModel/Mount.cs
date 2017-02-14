using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainContainer.Exception
{
    public class Mount : Item
    {
        int speed;
        int carryingCapacity;
        Armor armor;
        Item saddle;
        /*
         * def types are land, aquatic and flying.
         * DM may define new types. Aquatic & flying require
         * exotic saddles
         * */
        String mountType;
        Dictionary<Item, int> carriedItems;

        public Mount(string name, string description, int currency, int speed, int carryingCapacity, Armor armor, Item saddle, string mountType, Dictionary<Item, int> carriedItems)
            : base(name, description, currency)
        {
            int totalCarriedWeight = CalcCarriedItemWeight();
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

        public int CarryingCapacity
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

        public int CalcCarriedItemWeight()
        {
            int totalCarriedWeight = 0;
            foreach (KeyValuePair<Item, int> entry in carriedItems)
            {
                totalCarriedWeight += (entry.Key.Weight * entry.Value);
            }
            return totalCarriedWeight;
        }
    }
}