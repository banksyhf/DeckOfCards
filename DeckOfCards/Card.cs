using DeckOfCards.Interfaces;
using System.Drawing;

namespace DeckOfCards
{
    public class Card
    {
        private string _name;
        public string Name { get { return _name; } }

        private Bitmap _image;
        public Bitmap Image { get { return _image; } }

        private ISuit _suit;
        public ISuit Suit { get { return _suit; } }
        
        public Card(string name, Bitmap image, ISuit suit)
        {
            _name = name;
            _image = image;
            _suit = suit;
        }
    }
}
