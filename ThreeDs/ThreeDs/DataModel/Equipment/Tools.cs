using System;
namespace ThreeDs.DataModel
{
	public class Tool : Item
	{
		string type;

		public string Type
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

		public Tool(string name, string desc, int cev, double weight, string type) : base(name, desc, cev, weight)
		{
			this.type = type;
		}

		public static Tool ALCHEMISTSUP { get { return new Tool("Alchemist's Supplies", "Items needed to pursue alchemy", 5000, 8, "Artisan Tool"); } }
		public static Tool BREWERSUP { get { return new Tool("Brewer's Supplies", "Items needed to pursue brewery", 2000, 9, "Artisan Tool"); } }
		public static Tool CALIGRAPHERSUP { get { return new Tool("Calligrapher's Supplies", "Items needed to pursue calligraphy", 1000, 5, "Artisan Tool"); } }
		//TODO: add the rest of the base tools as static properties

	}
}
