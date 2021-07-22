/*		frenchDeck.cs
**
*/

namespace CardDeck
{
    public class FrenchDeck : Deck<FrenchCard>
    {
        /*********************************************************************
         * @brief Fills and shuffles the cards list.
         * @details Fills the cards list with a full set of French-Suited playing
         * cards and shuffles.
         *********************************************************************/
        public FrenchDeck() : base()
        {
            FillDeck();
            Shuffle();
        }

        /*********************************************************************
         * @brief Fills the cards list.
         * @details Fills the cards list with a full set of French-Suited playing
         * cards.
         *********************************************************************/
        public override void FillDeck()
        {
            for (Suit i = Suit.Heart; i <= Suit.Spade; i++)
            {
                for (Rank j = Rank.Two; j <= Rank.Ace; j++)
                {
                    Cards.Add(new FrenchCard(i, j));
                }
            }
        }
    }
}
