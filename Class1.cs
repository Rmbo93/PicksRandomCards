using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicksRandomCards
{
    internal class CardPicker
    {

        static Random random = new Random();

        public static string[] PickSomCards(int numberOfCards)
        {

            string[] peckedCards = new string[numberOfCards];

            for (int i = 0; i < numberOfCards; i++)
            {
                peckedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return peckedCards;
        }

       

        private static string RandomSuit()
        { 

            //Get a random number from 1 to 5
            int value = random.Next(1,5);

            if (value == 1) return "Spades";

            if (value == 2) return "Hearts";

            if (value == 3) return "Clubs";

            return "Diamonds";
            

        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);

            if (value == 1) return " ACE";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }
    }
}

    