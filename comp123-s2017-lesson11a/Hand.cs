using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Khim Tang
 * Date: July 27. 2017
 * Description: This is the Hand class 
 * It inherits from the Cardlist class
 * Version: 0.1 - Created the Hand class 
*/

namespace comp123_s2017_lesson11a
{
    public class Hand : CardList
    {
        //PRIVATE INSTANCE VARIABLES

        //PUBLIC PROPERTIES

        //CONSTRUCTOR

        //PRIVATE/PROTECTED METHODS
        /// <summary>
        /// This method initializes class variables and other objects
        /// </summary>
        protected override void _initialize()
        {
            //This method is currently empty
        }

        //PUBLIC METHODS
        /// <summary>
        /// This method overrides the built-in ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += "The Hand contains \n";
            outputString += "=====================================\n";

            foreach (Card card in this)
            {
                outputString += "The" + card.Face + " of " + card.Suit + "\n";
            }
            return outputString;
        }
        
    }
}