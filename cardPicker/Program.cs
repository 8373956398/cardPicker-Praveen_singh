using System;

namespace cardPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick:");
            string line = Console.ReadLine();
            int numberOfCards = Convert.ToInt32(line);
            if (numberOfCards > 52)
            {
                Console.WriteLine("there is only 52 cards in a deck");
            }
            else
            {
                foreach(string card in randomCardPicker.pickCard(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }

        }
    }
}
