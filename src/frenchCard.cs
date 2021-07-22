/*	    frenchCard.cs
**
*/

namespace CardDeck
{
    public enum Suit        //! Suit values for French-suited cards
    {
        Heart,
        Diamond,
        Club,
        Spade
    }

    public enum Rank        //! Rank values for French-suited cards
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    /*********************************************************************
	 * @brief FrenchCard class.
	 * @details Holds values for a French-suited playing card.
	 *********************************************************************/
    public class FrenchCard
    {
        public Suit cardSuit { get; set; }      //!< The card's suit
        public Rank cardRank { get; set; }      //!< The card's rank

        /*********************************************************************
		 * @brief Initializes a new FrenchCard.
		 * @details Assigns values to the cardSuit and cardRank variables.
		 * @param newSuit The Suit value for the new FrenchCard.
		 * @param newRank The Rank value for the new FrenchCard.
		 *********************************************************************/
        public FrenchCard(Suit newSuit, Rank newRank)
        {
            cardSuit = newSuit;
            cardRank = newRank;
        }

        
    }
}
