using System;

class Program
{
    static void Main(string[] args)
    {
        Deck deck = null;
        while (true)
        {
            Console.WriteLine("Deck of Cards");
            Console.WriteLine("1 - Create");
            Console.WriteLine("2 - Shuffle");
            Console.WriteLine("3 - Deal");
            Console.WriteLine("4 - Display Deck");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        deck = new Deck();
                        Console.WriteLine("Deck created!");
                        break;
                    case "2":
                        if (deck == null) throw new InvalidOperationException("Deck not created.");
                        deck.Shuffle();
                        Console.WriteLine("Deck shuffled!");
                        break;
                    case "3":
                        if (deck == null) throw new InvalidOperationException("Deck not created.");
                        Console.Write("How many cards to deal? ");
                        int numberOfCards = int.Parse(Console.ReadLine());
                        var dealtCards = deck.Deal(numberOfCards);
                        foreach (var card in dealtCards)
                        {
                            Console.WriteLine(card);
                        }
                        break;
                    case "4":
                        if (deck == null) throw new InvalidOperationException("Deck not created.");
                        deck.Display();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine();
        }
    }
}