using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
    class Board
    {
        private IList<Card> Cards;
        private const int MaxCards = 10;

        public Board()
        {
            Cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            if (CanAddCard(card) && Cards.Count < MaxCards)
            {
                Cards.Add(card);
                SortCards();
            }
        }

        public bool CanAddCard(Card card)
        {
            FaceValues currentFaceValue = card.FaceValue;
            IEnumerable<FaceValues> existingFaceValues = Cards.Select(x => x.FaceValue);
            return !existingFaceValues.Contains(currentFaceValue);
        }

        public bool IsBoardFull()
        {
            return Cards.Count == MaxCards;
        }

        public void ClearBoard()
        {
            Cards = new List<Card>();
        }

        private void SortCards()
        {
            Cards = Cards.OrderBy(x => x.FaceValue).ToList();
        }
    }
}
