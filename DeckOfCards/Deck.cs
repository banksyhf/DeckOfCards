using DeckOfCards.Suits;
using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        #region " Suits "

        private Clubs _clubs;
        public Clubs Clubs { get { return _clubs; } }

        private Hearts _hearts;
        public Hearts Hearts { get { return _hearts; } }

        private Diamonds _diamonds;
        public Diamonds Diamonds { get { return _diamonds; } }

        private Spades _spades;
        public Spades Spades { get { return _spades; } }

        #endregion

        #region " Cards "

        private List<Card> _cards;
        public Card[] Cards { get { return _cards.ToArray(); } }

        #endregion

        private Random _random;

        public Deck()
        {
            _random = new Random();

            _clubs = new Clubs();
            _hearts = new Hearts();
            _diamonds = new Diamonds();
            _spades = new Spades();

            _cards = new List<Card>();

            _cards.AddRange(Utils.GetCardsFromSuit(_clubs));
        }

        public void Shuffle(int shuffles)
        {
            if (shuffles <= 0) throw new ArgumentException("Shuffles must be greater than 0.", "shuffles");

            for (int i = 0; i < shuffles; i++)
            {
                Shuffle();
            }
        }

        public void Shuffle()
        {
            int index = _cards.Count - 1;

            while (index >= 0)
            {
                int newIndex = _random.Next(0, _cards.Count - 1);
                Card oldCard = _cards[index];
                _cards[index] = _cards[newIndex];
                _cards[newIndex] = oldCard;

                index -= 1;
            }
        }

    }
}
