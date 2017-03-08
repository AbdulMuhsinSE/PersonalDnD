using System;
namespace ThreeDs.Utils
{
	public class DieFormula
	{
		int numberOfDie;
		Dice die;
		int numToAdd;

		public int NumberOfDie
		{
			get
			{
				return numberOfDie;
			}

			set
			{
				numberOfDie = value;
			}
		}

		public Dice Die
		{
			get
			{
				return die;
			}

			set
			{
				die = value;
			}
		}

		public int NumToAdd
		{
			get
			{
				return numToAdd;
			}

			set
			{
				numToAdd = value;
			}
		}

		public DieFormula(int numberOfDie, Dice die, int numToAdd)
		{
			NumberOfDie = numberOfDie;
			Die = die;
			NumToAdd = numToAdd;
		}

		public int averageValue()
		{
			return ((NumberOfDie * (int)die) + numToAdd);
		}

		public override string ToString()
		{
			return string.Format("[numberOfDie={0}die={1} + numToAdd={2}]", numberOfDie, die, numToAdd);
		}
	}
}
