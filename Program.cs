using System;
using System.Collections.Generic;
using System.Drawing;

namespace DeckOfCards
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("-----------------");
            Console.WriteLine("Let's start! (Y/N)");
            Console.WriteLine("-----------------");
            Console.ResetColor();

            // Console.WriteLine("Let's start! (Y/N)");
            string InputLine = Console.ReadLine();
            if (InputLine == "Y")
            {
                BlackJack game = new BlackJack();
                game.startGame();
                game.hitOrStay();
            }

            // Deck newDeck = new Deck();
            // newDeck.shuffle();
            // newDeck.dealTopCard();

            // Player playerA = new Player("playerA");
            // Player house = new Player("House");
            // playerA.drawCard(newDeck);
        }
    }
}