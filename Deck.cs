using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Deck
{
    List<Card> cards = new List<Card>();

    //Deck Constructor
    public Deck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                Card card = new Card(rank, suit);
              	cards.Add(card);
            }
        }
    }

    //Implement a property to get Cards
    public bool Empty { get { return cards.Count == 0; } }
		
    //Takes top card from deck (if deck is not empty, otherwise return null)
    public Card TakeTopCard()
    {
        //implementation
      	if (this.Empty) 
        {
          return null;
        }
				else
        {
          Card topCard = cards[0];
          cards.RemoveAt(0);
          return topCard;
        }
    }

    //Shuffle Method
    public void Shuffle()
    {
        //implementation
  			Random random = new Random();
      	for (int i = cards.Count - 1; i > 0; i--) {
          int randomIndex = random.Next(0, i + 1);
          
          Card temp = cards[i];
          cards[i] = cards[randomIndex];
          cards[randomIndex] = temp;
        }
      
    }

    //Cut method
    public void Cut(int index)
    {
      List<Card> cutCards = cards.Take(index).ToList();
      List<Card> remainingCards = cards.Skip(index).ToList();
      
      cards = remainingCards.Concat(cutCards).ToList();
    }
}

