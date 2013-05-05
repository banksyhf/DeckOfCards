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

            BuildDeck();
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

        public void RemoveCard(int index)
        {
            _cards.RemoveAt(index);
        }

        public void RemoveCard(Card card)
        {
            _cards.Remove(card);
        }

        public void RemoveCards(params int[] indexes)
        {
            foreach (int i in indexes)
                _cards.RemoveAt(i);
        }

        public void RemoveCards(params Card[] cards)
        {
            foreach (Card card in cards)
                _cards.Remove(card);
        }

        public void BuildDeck()
        {
            _cards = new List<Card>();

            _cards.AddRange(Utils.GetCardsFromSuit(_clubs));
            _cards.AddRange(Utils.GetCardsFromSuit(_hearts));
            _cards.AddRange(Utils.GetCardsFromSuit(_diamonds));
            _cards.AddRange(Utils.GetCardsFromSuit(_spades));
        }

    }
}
