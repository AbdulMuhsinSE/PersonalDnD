using System;
namespace MainContainer.DataModel
{
	public class Sense
	{
		string name;
		string description;
		int range;
		string caveat;

		public Sense(string name, string description, int range, string caveat)
		{
			Name = name;
			Description = description;
			Range = range;
			Caveat = caveat;
		}

		string Name
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

		string Description
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

		int Range
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

		string Caveat
		{
			get
			{
				return caveat;
			}

			set
			{
				caveat = value;
			}
		}



	}
}
