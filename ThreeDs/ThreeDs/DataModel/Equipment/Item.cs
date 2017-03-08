using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThreeDs.DataModel
{
    public class Item
    {
        public readonly static Item PACKSADDLE = new Item("Pack Saddle", "saddle", 500,15);
        public readonly static Item RIDINGSADDLE = new Item("Riding Saddle", "saddle", 1500,25);
        public readonly static Item MILITARYSADDLE = new Item("Military Saddle", "saddle", 2000, 30);
        public readonly static Item EXOTICSADDLE = new Item("Exotic Saddle", "saddle", 6000, 60);



        string name;
        string description;
        //if CEV = 0 then the item cannot be solD
        //be advised that when selling to a shop, CEV is multiplied by a modifier x<1
        //thus items with value of 1 can only be bought and traded
        int currencyEquivalentValue;
		double weight;

        public Item(string name, string description, int currencyEquivalentValue)
        {
            this.name = name;
            this.description = description;
            this.currencyEquivalentValue = currencyEquivalentValue;
            this.weight = 0;
        }

        public Item(string name, string description, int currencyEquivalentValue, double weight) : this(name, description, currencyEquivalentValue)
        {
            this.weight = weight;
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

        public int CurrencyEquivalentValue
        {
            get
            {
                return currencyEquivalentValue;
            }

            set
            {
                currencyEquivalentValue = value;
            }
        }

        public double Weight
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
    }
}