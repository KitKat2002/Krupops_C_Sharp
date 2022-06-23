using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethods
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<CardClass>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                "Jack", "Queen", "King", "Ace"
            };
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    CardClass card = new CardClass();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<CardClass> Cards { get; set; }
    }
}
