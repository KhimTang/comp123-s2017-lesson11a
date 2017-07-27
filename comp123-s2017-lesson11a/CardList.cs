using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Khim Tang
 * Date: July 27. 2017
 * Description: This is the abstract superclass/base class CardList
 * It inherits from the the built - in List generic collection and consumes the Card class
 * Version: 0.1 - Created the CardList class 
*/

namespace comp123_s2017_lesson11a
{
    public abstract class CardList : List<Card>
    {
        //PRIVATE INSTANCE VARIABLES

        //PUBLIC PROPERTIES

        //CONSTRUCTOR
        public CardList()
        {
            this._initialize();
        }

        //PRIVATE METHODS
        protected abstract void _initialize();
        

        

        //PUBLIC METHODS

    }
}