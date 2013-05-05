using DeckOfCards.Interfaces;

namespace DeckOfCards.Suits
{
    public class Clubs : ISuit
    {
        public Card Ace
        {
            get { return new Card("Ace", Utils.GetBitmap(1, this), this); }
        }

        public Card Two
        {
            get { return new Card("Two", Utils.GetBitmap(2, this), this); }
        }

        public Card Three
        {
            get { return new Card("Three", Utils.GetBitmap(3, this), this); }
        }

        public Card Four
        {
            get { return new Card("Four", Utils.GetBitmap(4, this), this); }
        }

        public Card Five
        {
            get { return new Card("Five", Utils.GetBitmap(5, this), this); }
        }

        public Card Six
        {
            get { return new Card("Six", Utils.GetBitmap(6, this), this); }
        }

        public Card Seven
        {
            get { return new Card("Seven", Utils.GetBitmap(7, this), this); }
        }

        public Card Eight
        {
            get { return new Card("Eight", Utils.GetBitmap(8, this), this); }
        }

        public Card Nine
        {
            get { return new Card("Nine", Utils.GetBitmap(9, this), this); }
        }

        public Card Ten
        {
            get { return new Card("Ten", Utils.GetBitmap(10, this), this); }
        }

        public Card Jack
        {
            get { return new Card("Jack", Utils.GetBitmap(11, this), this); }
        }

        public Card Queen
        {
            get { return new Card("Queen", Utils.GetBitmap(12, this), this); }
        }

        public Card King
        {
            get { return new Card("King", Utils.GetBitmap(13, this), this); }
        }
    }
}
