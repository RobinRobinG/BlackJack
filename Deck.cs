using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();
        public Deck() => buildDeck();

        public Deck buildDeck()
        {
            string[] suits = {"Spades", "Clubs", "Hearts", "Diamonds"};
            for (int val = 1; val < 14; val++)
            {
                for (int suit = 0; suit < suits.Length; suit++)
                {
                    cards.Add(new Card(val, suits[suit]));
                }
            }
            return this;
        }
        public int chooseRandomIdx()
        {
            Random rand = new Random();
            int randomIdx = rand.Next(0, cards.Count - 1);
            return randomIdx;
        }
        public Card dealTopCard()
        {
            //Console.WriteLine($"Deal the top-most card in deck:");
            Card topCard = cards[0];
            cards.RemoveAt(0);
            return topCard;
        }
        public Card dealRandomCard()
        {
            int randomIdx = chooseRandomIdx();
            Card randomCard = cards[randomIdx];
            Console.WriteLine($"Random Card: {randomCard.stringVal} of {randomCard.suit}");
            cards.RemoveAt(0);
            return randomCard;
        }
        public void reset()
        {
            cards.Clear();
            buildDeck().shuffle();
        }
        public Deck shuffle()
        {
            for (int i = 0; i < cards.Count - 1; i++)
            {
                int randomIdx = chooseRandomIdx();
                Card temp = cards[i];
                cards[i] = cards[randomIdx];
                cards[randomIdx] = temp;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"The deck is shuffled.");
            Console.ResetColor();
            return this;
            }
        public Deck displayDeck()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                Console.WriteLine($"{cards[i].stringVal} of {cards[i].suit}");
            }
            return this;
        }
        public void getDeckCount() => Console.WriteLine(cards.Count);
    }
}