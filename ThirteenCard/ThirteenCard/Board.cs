using System;
using System.Collections.Generic;

namespace ThirteenCard
{
    class Board
    {
        private List<Player> players = new List<Player>() {new Player(), new Player(), new Player(), new Player()};
        

        public bool legalPlay(List<Card> chosenCards)
        {

            return false;
        }

        public void setPower() // rule of the game
            // mainDeck = {"A Spades", "A Clubs", "A Diamond", "A Hearts", "2 Spades", ... ,"K Diamond", "K Hearts" }
        {
            var Ato2 = Deck._mainDeck.GetRange(0, 8);// get all A and 2 cards
            Deck._mainDeck.RemoveRange(0,8); // delete A and 2 cards from main
            Deck._mainDeck.AddRange(Ato2); // add A and 2 cards to the end
            for (int i = 0; i < Deck._mainDeck.Count; i++)
            {
                Deck._mainDeck[i].power = i;
            }
        }

        public void preStart()
        {
            //Deck.Shuffle();
            foreach (var player in players)
            {
                player.getCard();
            }
        }

        public void run()
        {
            setPower();
            preStart();
            foreach (var player in players)
            {
                Console.WriteLine(player.ToString());
            }

        }
    }
}