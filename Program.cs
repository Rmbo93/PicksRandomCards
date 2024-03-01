namespace PicksRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the number of cards to pick
            Console.Write("Enter the number of cards to pick: ");

            // Read the input from the user
            string line = Console.ReadLine();

            // Try to parse the input string into an integer using int.TryParse
            if (int.TryParse(line, out int numberOfCards))
            {
                // If parsing is successful, call CardPicker.PickSomCards to pick the cards
                string[] cards = CardPicker.PickSomCards(numberOfCards);

                // Iterate over the picked cards array and print each card
                for (int i = 0; i < cards.Length; i++)
                {
                    Console.WriteLine(cards[i]);
                }
            }
            else
            {
                // If parsing fails, notify the user to enter a valid number
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}