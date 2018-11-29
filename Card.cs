namespace DeckOfCards
{
  public class Card {
      public int val; // numerical value of the card 1-13 as integers
      public int point; 
      public string suit;
      public string stringVal; // value of the card ex. (Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King)
      public Card(int val, string suit) // card constructor
      {
          this.val = val;
          this.suit = suit;
          if (val == 1)
          {
              stringVal = "Ace";
              point = 11;
          }
          else if (val == 11)
          {
              stringVal = "Jack";
              point = 10;
          }
          else if (val == 12)
          {
              stringVal = "Queen";
              point = 10;
          }
          else if (val == 13)
          {
              stringVal = "King";
              point = 10;
          }
          else
          {
              stringVal = val.ToString();
              point = val;
          }
      } 
  }
}