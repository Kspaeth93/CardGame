namespace CardGame
{
    public class Card
    {
        public readonly FaceValues FaceValue;
        public readonly Suits Suit;

        public Card(Suits suit, FaceValues faceValue)
        {
            FaceValue = faceValue;
            Suit = suit;
        }
    }
}
