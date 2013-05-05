using DeckOfCards.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

namespace DeckOfCards
{
    internal static class Utils
    {
        public static Bitmap GetBitmap(int cardNumber, ISuit suit)
        {
            Assembly dll = typeof(Utils).Assembly;
            string[] names = dll.GetManifestResourceNames();

            foreach (string imageName in names)
            {
                if (imageName.Contains(cardNumber.ToString()) && imageName.Contains(suit.GetType().Name))
                {
                    return new Bitmap(dll.GetManifestResourceStream(imageName));
                }
            }
            return null;
        }

        public static Card[] GetCardsFromSuit(ISuit suit)
        {
            List<Card> cards = new List<Card>();

            Type card = typeof(Card);

            PropertyInfo[] properties = typeof(ISuit).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (property.PropertyType == card)
                {
                    object value = property.GetValue(suit, null);

                    Card cardValue = (Card)value;

                    cards.Add(cardValue);
                }
            }
            return cards.ToArray();
        }
    }
}
