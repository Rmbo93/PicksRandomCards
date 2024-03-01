namespace PicksRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            Console.Write("Enter the nuber if cards to pick: ");

            string line = Console.ReadLine();


            // int.TryParse to convert string to int 

            if (int.TryParse(line, out int numberOfCards))
            {
                string[] cards = CardPicker.PickSomCards(numberOfCards);
                for (int i = 0; i < cards.Length; i++)
                {
                    Console.WriteLine(cards[i]);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
    }