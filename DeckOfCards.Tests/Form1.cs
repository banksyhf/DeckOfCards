using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DeckOfCards;

namespace DeckOfCards.Tests
{
    public partial class Form1 : Form
    {
        Deck Deck;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deck = new Deck();

            pictureBox1.Image = Deck.Cards[0].Image;      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deck.Shuffle(8);

            pictureBox1.Image = Deck.Cards[0].Image;
        }
    }
}
