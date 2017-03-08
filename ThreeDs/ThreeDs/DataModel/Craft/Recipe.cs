using System;
using System.Collections.Generic;
using ThreeDs.DataModel;

namespace DataModel.Craft
{
	public class Recipe : Item
	{
		Tool neededProficency;
		Item createdItem;
		int numberOfItemsCreated;
		List<Tuple<Item, int>> neededItems;


		public Recipe(string name, Tool neededProficency, Item createdItem, int numberOfItemsCreated, List<Tuple<Item,int>> neededItems,int value) : base(name,"",value)
		{
			this.neededProficency = neededProficency;
			this.createdItem = createdItem;
			this.numberOfItemsCreated = numberOfItemsCreated;
			this.neededItems = neededItems;
		}

		public Tool NeededProficency
		{
			get
			{
				return neededProficency;
			}
			set
			{
				neededProficency = value;
			}
		}

		public Item CreatedItem
		{
			get
			{
				return createdItem;
			}
			set
			{
				createdItem = value;
			}
		}


	}
}
