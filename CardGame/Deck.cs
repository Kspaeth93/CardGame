using System;
using System.Collections.Generic;

namespace CardGame
{
    public enum Suits
    {
        Hearts, Clubs, Spades, Diamonds
    };

    public enum FaceValues
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    };

    public class Deck
    {
        private IList<Card> Cards;

        public Deck()
        {
            Cards = new List<Card>();

            int numSuits = Enum.GetValues(typeof(Suits)).Length;
            int numFaceValues = Enum.GetValues(typeof(FaceValues)).Length;

            for (int i = 0; i < numSuits; i++)
            {
                for (int j = 0; j < numFaceValues; j++)
                {
                    Card card = new Card((Suits) i, (FaceValues) j);
                    Cards.Add(card);
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();

            for (int i = Cards.Count - 1; i > 1; i--)
            {
                int randomInt = random.Next(i + 1);

                Card card = Cards[randomInt];
                Cards[randomInt] = Cards[i];
                Cards[i] = card;
            }
        }

        public Card DrawCard()
        {
            Card card;

            try
            {
                card = Cards[0];
                Cards.RemoveAt(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                card = null;
            }
            
            return card;
        }
    }
}
