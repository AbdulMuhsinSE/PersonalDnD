using System;
using System.Linq;

namespace MainContainer.Utils
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
    }
}
