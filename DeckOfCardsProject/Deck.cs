using System;
using System.Collections.Generic;

public class Deck
{
    private List<Card> cards;
    private Random random;

    public Deck()
    {
        cards = new List<Card>();
        random = new Random();
        Create();
    }

    public void Create()
    {
        string[] suits = { "Cloves", "Diamond", "Heart", "Spade" };
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        foreach (var suit in suits)
        {
            foreach (var rank in ranks)
            {
                cards.Add(new Card(suit, rank));
            }
        }
    }

    public void Shuffle()
    {
        int n = cards.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            Card value = cards[k];
            cards[k] = cards[n];
            cards[n] = value;
        }
    }

    public List<Card> Deal(int numberOfCards)
    {
        if (numberOfCards > cards.Count)
        throw new InvalidOperationException("Not enough cards to deal.");

        List<Card> dealtCards = new List<Card>();
        for (int i = 0; i < numberOfCards; i++)
        {
            dealtCards.Add(cards[0]);
            cards.RemoveAt(0);
        }
        return dealtCards;
    }

    public void Display()
    {
        foreach (var card in cards)
        {
            Console.WriteLine(card);
        }
        Console.WriteLine($"Number of cards: {cards.Count}");
    }
}