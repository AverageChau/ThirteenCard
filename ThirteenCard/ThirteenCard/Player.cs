using System;
using System.Collections.Generic;

namespace ThirteenCard
{
    class Player
    {
        private Deck playerDeck = new Deck();
        private List<Card> chosenCards = new List<Card>();

        public void getCard()
        {
            playerDeck.getSubDeck(13);
        }

        public void chooseCard(int index) // choose a card in the player Deck by index
        {
            if (index < playerDeck.Count)
            {
                chosenCards.Add(playerDeck[index]);
            }
            else
            {
                throw new ArgumentException($"index {index} is not in range {playerDeck.Count}");
            }
        }

        public void discard(int index) // discard a card by its index in chosenCards
        {
            if (index < chosenCards.Count)
            {
                chosenCards.RemoveAt(index);
            }
            else
            {
                throw new ArgumentException($"index {index} is not in range {chosenCards.Count}");
            }
        }

        public void discard() // discard all cards in chosenCards
        {
            chosenCards.Clear();
        }

        public List<Card> play()
        {
            return chosenCards;
        }

        public void apply() // if play successfully
        {
            playerDeck.Remove(chosenCards);
        }

        public override string ToString()
        {
            return playerDeck.ToString();
        }
    }
}