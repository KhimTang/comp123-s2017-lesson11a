using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Khim Tang
 * Date: July 26. 2017
 * Description: This is the Deck class 
 * It inherits from the List generic and uses Card as the base type
 * Version: 0.2 - Added the Shuffle Method 
*/

namespace comp123_s2017_lesson11a
{
    public class Deck : CardList //think as (Deck is a card list)
    {
        //PRIVATE INSTANCE VARIABLES
        private Random _random;

        //PUBLIC PROPERTIES

        //PRIVATE PROPERTIES
        public Random Random { get { return this._random; } }

        //CONSTRUCTOR
        /// <summary>
        /// This is the main constructor.
        /// </summary>
        public Deck()
        {
            this._initialize();
        }

        //PRIVATE METHODS
        /// <summary>
        /// This is the Initialize method it sets values for private variables
        /// and public properties as well as other class objects.
        /// </summary>
        protected override void _initialize()
        {
            // initialize the pseudo-random number generator
            this._random = new Random();

            //This builds the deck - fills it with cards
            for (int suit = (int)Suit.Clubs; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = (int)Face.Ace; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }

            }

        }
        //PUBLIC METHODS
        /// <summary>
        /// This method overrides the built-in ToString method.
        /// </summary>
        /// <returns>
        /// This method returns the current cards in the deck
        /// </returns>
        public override string ToString()
        {
            string outputString = "";

            foreach (Card card in this)
            {
                outputString += "The" + card.Face + "of" + card.Suit + "\n";
            }
            return outputString;
        }
        /// <summary>
        /// This method shuffles the deck by using random indices to select two cards a time
        /// It uses a Fisher-Yates like algorithm
        /// </summary>
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;

            for (int card = 0; card < this.Count; card++)
            {
                firstCard = this.Random.Next(0, 52);
                secondCard = this.Random.Next(0, 52);

                tempCard = (Card)this[secondCard].Clone();
                this[secondCard].Face = this[firstCard].Face;
                this[secondCard].Suit = this[firstCard].Suit;
                this[firstCard].Face = tempCard.Face;
                this[firstCard].Suit = tempCard.Suit;
            }
        }
        /// <summary>
        /// This method removes a Card from element 0 in the List and return this Card
        /// </summary>
        /// <returns></returns>
        public Card Deal1()
        {
            Card firstCard = (Card)this[0].Clone();
            this.RemoveAt(0); //removes the top card
            Console.WriteLine("Deck contains: " + this.Count + "Cards");
            return firstCard;
        }
        public Hand Deal5()
        {
            Card card;
            Hand firstCard = new Hand();
            for (int x = 0; x <= 4; x++)
            {
                card = this[x];
                this.RemoveAt(0); //removes the top card
                firstCard.Add(card);
                
        }
            Console.WriteLine("Deck contains: " + this.Count + "Cards");
            return firstCard;
            
           
        }
    }
}




