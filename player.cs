using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        public string name;
        public List<Card> hand;
        public int handVal;
        public Player(string name) // player constructor
        {
            this.name = name;
            this.hand = new List<Card>();
            this.handVal = 0;
        }
        public Player drawCard(Deck deck)
        {
            Card drawnCard = deck.dealTopCard();
            hand.Add(drawnCard);
            handVal += drawnCard.point;
            return this;
        }
        public Player discardCard(int cardIdx)
        {
            if (cardIdx > hand.Count)
            {
                Console.WriteLine  ("Sorry! No card at that specified index. Cannot discard.");
                return null;
            }
            else
            {
                Card discardedCard = hand[cardIdx];
                Console.WriteLine($"Discarded Card {discardedCard.stringVal} of {discardedCard.suit}");
                hand.RemoveAt(cardIdx);
                return this;
            }
        }
        public void showHand()
        {
            foreach (Card card in hand)
            {
                if (card.suit == "Hearts" || card.suit == "Diamonds")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{card.stringVal} of {card.suit}");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"{card.stringVal} of {card.suit}");
                    Console.ResetColor();           
                }
            }
        }
        public int showHandVal()
        {
            if (handVal >= 17 )
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{handVal} Points");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{handVal} Points");
                Console.ResetColor(); 
            }
            return handVal;
        }
    }
}