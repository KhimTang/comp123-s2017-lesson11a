using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Khim Tang
 * Date: July 26. 2017
 * Description: This is a demo for Lesson 11
 * Version: 0.3 Test Shuffle method of the Deck class
*/

namespace comp123_s2017_lesson11a
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand hand = new Hand(); //new empty hand container

            Deck deck = new Deck();
            Console.WriteLine("Original Deck");
            Console.WriteLine("=======================================");
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine("Shuffled Deck");
            Console.WriteLine("=======================================");
            Console.WriteLine(deck.ToString());

            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());
            hand=deck.Deal5(); //creates a new Hand object and assigns it to hand
            Console.WriteLine(hand.ToString());

            hand.HighestCards();

        }
    }
}
