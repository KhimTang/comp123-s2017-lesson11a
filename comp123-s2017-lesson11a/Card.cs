using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Khim Tang
 * Date: July 25. 2017
 * Description: This is the Card class
 * Version: 0.2 - Implemented the ICloneable interface
*/
namespace comp123_s2017_lesson11a
{
    public class Card : ICloneable
    {
        //PRIVATE INSTANCE VARIABLES
        private Face _face;
        private Suit _suit;

        //PUBLIC PROPERTIES

        public Face Face { get { return this._face; } set { this._face = value; } }
        public Suit Suit { get { return this._suit; } set { this._suit = value; } }
            
        //CONSTRUCTORS
        /// <summary>
        /// This is the main constructor.
        /// It takes two paramenters/arguements - face (Face) - suit (Suit)
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
        /// <summary>
        /// This method overrides the built-in Clone method
        /// </summary>
        /// <returns></returns>

        public object Clone()
        {
            return new Card(this.Face, this.Suit);
        }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
}