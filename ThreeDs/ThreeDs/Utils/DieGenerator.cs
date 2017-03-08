using System;
using System.Linq;

namespace ThreeDs.Utils
{
    public class DieGenerator
    {
        AlmostTrueRandomness random;
        private static DieGenerator dieGeneratorSingleton;
        private DieGenerator()
        {
            random = new AlmostTrueRandomness();
        }

        public static DieGenerator getDieGenerator()
        {

            if (dieGeneratorSingleton == null)
            {
                dieGeneratorSingleton = new DieGenerator();
            }

            return dieGeneratorSingleton;
        }

        public String rollDie(int numberOfRolls, Dice dietype)
        {
            int[] rolls = new int[numberOfRolls];
            for(int i = 0; i < numberOfRolls; i++)
            {
                rolls[i] = random.Next(1,((int)dietype)+1);
            }
            String toReturn = "Your rolls are";
            foreach (int roll in rolls) {
                toReturn += " " + roll + ",";
            }
            toReturn += " for a total of " + rolls.Sum();
            return toReturn;
        }

		public String rollDie(DieFormula df)
		{
			int[] rolls = new int[df.NumberOfDie];
			for (int i = 0; i < rolls.Length; i++)
			{
				rolls[i] = random.Next(1, ((int)df.Die) + 1);
			}
			String toReturn = "Your rolls are";
			foreach (int roll in rolls)
			{
				toReturn += " " + roll + ",";
			}
			toReturn += " for a total of " + rolls.Sum() + "mod: " + df.NumToAdd;
			return toReturn;
		}

		public int rollDieInt(DieFormula df)
		{
			int[] rolls = new int[df.NumberOfDie];
			for (int i = 0; i < rolls.Length; i++)
			{
				rolls[i] = random.Next(1, ((int)df.Die) + 1);
			}
			return rolls.Sum() + df.NumToAdd;;
		}
    }
}
