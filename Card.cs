using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cards;
public class Card
{
    //Fields, example: Rank rank;
    //check the help documentation for the fields
    

    //Card Constructor


    //Define properties for all above fields
    //code example: public Suit Suit { get { return suit; } }

    // Internally sets up private up [Suit, Ranks, (bool)Faceup] variable, creates
    // Public get method, and private set method
    // Fields are not needed with properties running on .Net 9.0
    public Suit Suit { get; private set; }

    public Rank Rank { get; private set; }
    public bool Faceup { get; private set; }

    public Card(Rank rank, Suit suit)
    {
        Rank = rank;
        Suit = suit;
        Faceup = false;
    }
    public void FlipOver()
    {
        //implementation 
        Faceup = !Faceup;
    }
        
}
