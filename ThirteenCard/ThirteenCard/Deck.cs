using System;
using System.Collections.Generic;

namespace ThirteenCard
{
    class Deck
    {
        private const int TOTAL_CARD = 52;
        static Random rng = new Random();
        static readonly string[] AllSuits = {"Spades", "Clubs", "Diamond", "Hearts" };
        static readonly string[] AllRanks = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
        private List<Card> subDeck = new List<Card>();
        public static List<Card> _mainDeck = new List<Card>();

        public int Count => subDeck.Count;

        static Deck() // generate all cards.
        {
            foreach  (var suit in  AllRanks)
            {
                foreach (var rank in AllSuits) 
                {
                    var card = new Card(suit, rank);
                    _mainDeck.Add(card);
                }
            }
        }

        public Deck(int numcard) // create sub deck
        {
            getSubDeck(numcard);
        }

        public Deck() // create sub deck
        { }

        public static void Shuffle() //Fisher-Yates shuffle
        {
            if (_mainDeck.Count != TOTAL_CARD)
            {
                throw new ArgumentException(
                    $"Required {TOTAL_CARD} card in the main decks to shuffle, " +
                    $"only {_mainDeck}", $"__mainDeck.Count");
            }
            int n = _mainDeck.Count;
            while (n>1)
            {
                n--;
                int rand = rng.Next(n + 1);
                var temp = _mainDeck[n];
                _mainDeck[n] = _mainDeck[rand];
                _mainDeck[rand] = temp;
            }
        }


        public void getSubDeck(int numcard = 13)
        {
            subDeck = _mainDeck.GetRange(0, numcard);
            _mainDeck.RemoveRange(0,numcard);
        }

        public Card this[int cardNum]
        {
            get => subDeck[cardNum];
            set => subDeck[cardNum] = value;
        }

        public void Remove(List<Card> subSubDeck)
        {
            foreach (Card card in subSubDeck)
            {
                subDeck.Remove(card); // remove subSubDeck card from the main deck.
            }
        }



        public static string ToStringAll() // print all the cards in the deck
        {
            string output = "This is all the card of the deck: \n";
            foreach (var card in _mainDeck)
            {
                output += card.ToString() + "\n"; // concat
            }
            return output;
        }

        public override string ToString()
        {
            string output = "This desk contain: \n";
            foreach (var card in subDeck)
            {
                output += card.ToString() + "\n"; // concat
            }
            return output;
        }
    }
}