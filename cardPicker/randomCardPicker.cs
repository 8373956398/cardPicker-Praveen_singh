using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardPicker
{
    class randomCardPicker
    {
        static Random random = new Random();
        public static string[] pickCard(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for(int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = randomValue() + " of " + randomSuit();
            }
            return pickedCards;
        }

        private static string randomValue()
        {
            int value = random.Next(1,14);
            if (value == 1) return "Ace";
            if (value == 11) return "jack";
            if (value == 12) return "Queen";  
            if (value == 13) return "King";
            return value.ToString();
        }

        private static string randomSuit()
        {
            int value = random.Next(1,5);
            if (value == 1) return "Clubs";
            if (value == 2) return "Hearts";
            if (value == 3) return "Spades";
            return "Dimond";
        }
    }
}
