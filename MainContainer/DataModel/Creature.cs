using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainContainer.Utils;

namespace MainContainer.DataModel
{
    class Creature
    {
		string creatureName;
		string creatureType;
		int currentHP;
        Size size;
		int hitDieAmount;
        String type;
        Alignment alignment;
        /*
         * Each monster can have different speeds
         * the tuple is as follows
         * string --> name
         * int --> value 
         * 
         * Standard types for speeds are:
         * Walk
         * Burrow
         * Climb
         * Fly
         * Swim
         * Hover (always has a value of 0)
         * */
        List<Tuple<string, int>> speedArray;
        int[] abilityScores;
        List<AbilityScoreTypes> savingThrows;
		//TODO: List<> skills

		/*
		 * values can only be 'v', 'r' or 'i'
		 * which stand for vulnerability, resistance, and immunity respectively
		 * */
		Dictionary<DamageType, char> vulnerabilitiesResistancesImmunities;
		List<Sense> senses;
		List<string> languages;
		double challengeRating;
		//TODO: XP needs to be defined
		List<Features> specialTraits;
		List<Features> actions;
		List<Features> reactions;
		List<Features> legendaryActions;

		//TODO: figure out if I need a specfifc var for lairActions or if I could just include them in the legendary actions... for now I think that lair actions should be part of the lair objects

		List<Item> equipment;

		public string CreatureName
		{
			get
			{
				return creatureName;
			}

			set
			{
				creatureName = value;
			}
		}

		public string CreatureType
		{
			get
			{
				return creatureType;
			}

			set
			{
				creatureType = value;
			}
		}

		public int CurrentHP
		{
			get
			{
				return currentHP;
			}

			set
			{
				currentHP = value;
			}
		}

		public Size CSize
		{
			get
			{
				return size;
			}

			set
			{
				size = value;
			}
		}

		public int HitDieAmount
		{
			get
			{
				return hitDieAmount;
			}

			set
			{
				hitDieAmount = value;
			}
		}

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

		public Alignment CAlignment
		{
			get
			{
				return alignment;
			}

			set
			{
				alignment = value;
			}
		}

		public List<Tuple<string, int>> SpeedArray
		{
			get
			{
				return speedArray;
			}

			set
			{
				speedArray = value;
			}
		}

		public int[] AbilityScores
		{
			get
			{
				return abilityScores;
			}

			set
			{
				abilityScores = value;
			}
		}

		public List<AbilityScoreTypes> SavingThrows
		{
			get
			{
				return savingThrows;
			}

			set
			{
				savingThrows = value;
			}
		}

		public Dictionary<DamageType, char> VulnerabilitiesResistancesImmunities
		{
			get
			{
				return vulnerabilitiesResistancesImmunities;
			}

			set
			{
				vulnerabilitiesResistancesImmunities = value;
			}
		}

		public List<Sense> Senses
		{
			get
			{
				return senses;
			}

			set
			{
				senses = value;
			}
		}

		public List<string> Languages
		{
			get
			{
				return languages;
			}

			set
			{
				languages = value;
			}
		}

		public double ChallengeRating
		{
			get
			{
				return challengeRating;
			}

			set
			{
				challengeRating = value;
			}
		}

		public List<Features> SpecialTraits
		{
			get
			{
				return specialTraits;
			}

			set
			{
				specialTraits = value;
			}
		}

		public List<Features> Actions
		{
			get
			{
				return actions;
			}

			set
			{
				actions = value;
			}
		}

		public List<Features> Reactions
		{
			get
			{
				return reactions;
			}

			set
			{
				reactions = value;
			}
		}

		public List<Features> LegendaryActions
		{
			get
			{
				return legendaryActions;
			}

			set
			{
				legendaryActions = value;
			}
		}

		public List<Item> Equipment
		{
			get
			{
				return equipment;
			}

			set
			{
				equipment = value;
			}
		}

		//One value gives the dieformula the other uses the average hp of the creature.
		public DieFormula determineHP(bool calculated)
		{
			Dice hitdie;
			switch (this.size.Sname)
			{
				case ("tiny"):
					hitdie = Dice.d4;
					break;
				case ("small"):
					hitdie = Dice.d6;
					break;
				case ("medium"):
					hitdie = Dice.d8;
					break;
				case ("large"):
					hitdie = Dice.d10;
					break;
				case ("huge"):
					hitdie = Dice.d12;
					break;
				case ("gargantuan"):
					hitdie = Dice.d20;
					break;
				default:
					hitdie = Dice.d100;
					break;
			}
			DieFormula  df = new DieFormula(hitDieAmount, hitdie, (hitDieAmount * abilityScores[(int)AbilityScoreTypes.CON]));
			if (calculated)
			{
				currentHP = DieGenerator.getDieGenerator().rollDieInt(df);
			}
			else 
			{
				currentHP = df.averageValue();
			}
			return df;
		}

    }
}
