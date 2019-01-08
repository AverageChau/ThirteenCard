using System.Runtime.InteropServices.ComTypes;

namespace ThirteenCard
{
    class Card
    {
        public string suit { get; }
        public string rank { get; }

        public int power { get; set; }  

        public Card(string suit, string rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public override string ToString()
        {
            return $"Suit:{suit}, Rank: {rank}, power {power}";
        }
    }
}