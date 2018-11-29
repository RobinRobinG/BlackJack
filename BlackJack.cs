using System;

namespace DeckOfCards
{
  public class BlackJack
  {
    public Player player;
    public Player house;
    public Deck deck;
    public int playerpoints;
    public int housepoints;
    public BlackJack() {
        this.player = new Player("Player");
        this.house = new Player("House");
        this.deck = new Deck();
    }
    public void startGame()
    {
        deck = deck.shuffle();
        Console.WriteLine("Dealing Cards to Player and House...");
        player.drawCard(deck);
        house.drawCard(deck);
        player.drawCard(deck);
        house.drawCard(deck);
        Console.WriteLine("Player hand:");
        player.showHand();
        Console.WriteLine("Player has:");
        playerpoints = player.showHandVal();
        Console.WriteLine("House hand:");
        house.showHand();
        Console.WriteLine("House has:");
        housepoints = house.showHandVal();
    }
    public void hitOrStay(){
        while(player.handVal < 21 && house.handVal < 21){
            Console.WriteLine("***************************");
            Console.WriteLine("Player hit or stay? (H/S)");
            string InputLine = Console.ReadLine();
            if (InputLine == "H" || InputLine == "h")
            {
              player.drawCard(deck);
            }
            else
            {
              if (house.handVal >= 17)
              {
                break;
              }
            }
            if (house.handVal < 17)
            {
              house.drawCard(deck);
            }
              Console.WriteLine("Player hand:");
              player.showHand();
              Console.WriteLine("Player has:");
              playerpoints = player.showHandVal();
              Console.WriteLine("House hand:");
              house.showHand();
              Console.WriteLine("House has:");
              housepoints = house.showHandVal();
          }
          if (playerpoints <= 21 && (housepoints > 21 || housepoints < playerpoints))
          {
              Console.ForegroundColor = ConsoleColor.Green;
              Console.WriteLine("-------------");
              Console.WriteLine("Player Win!!!");
              Console.WriteLine("-------------");
              Console.ResetColor();
          }
          else
          {
              Console.ForegroundColor = ConsoleColor.Blue;
              Console.WriteLine("-------------");
              Console.WriteLine("House Win!!!");
              Console.WriteLine("-------------");
              Console.ResetColor(); 
          }
      }
  }
}  