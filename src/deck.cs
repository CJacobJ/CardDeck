/*		deck.cs
**
*/
using System.Collections.Generic;

using SafeRandom;

namespace CardDeck
{

	/*********************************************************************
	 * @brief Abstract Deck class.
	 * @details Holds a list and allows shuffling and drawing of the contained
	 * elements, as in a deck of cards.
	 *********************************************************************/
	public abstract class Deck<T>
	{
		protected List<T> Cards;        //!< Holds the list being used

		public abstract void FillDeck();

		public Deck()
		{
			Cards = new List<T>();
		}
		
		/*********************************************************************
		 * @brief Shuffles the Deck.
		 * @details Shuffles the Cards List using the Fisher–Yates shuffle.
		 *********************************************************************/
		public void Shuffle()
		{
			lock (Cards)
			{
				for (int i = Cards.Count - 1; i > 0; i--)
				{
					int r = SafeRandomGen.NextRand(i + 1);      // Pick a random
					if (i != r)
					{
						Swap(i, r);
					}
				}
			}
		}

		/*********************************************************************
		 * @brief Deals a card.
		 * @details Deals a card from the top of the Cards.
		 * @return Returns the element at the zero position. Returns default
		 * value if no such element.
		 *********************************************************************/
		public T Deal_one_card()
		{
			lock (Cards)
			{
				if (Cards.Count > 0)        // Treating 0 as the top of the deck
				{
					T c = Cards[0];
					Cards.RemoveAt(0);
					return c;
				}
				return default(T);
			}
		}

		/*********************************************************************
		 * @brief Gets number of cards.
		 * @details Gets number of remaining elements in the Cards list.
		 * @returns Number of remaining elements as int.
		 *********************************************************************/
		public int getCount()
        {
			return Cards.Count;
        }

		/*********************************************************************
		 * @brief Swaps two indexes in a list.
		 * @param a The first index.
		 * @param b The second index.
		 *********************************************************************/
		private void Swap(int a, int b)
		{
			T temp = Cards[a];
			Cards[a] = Cards[b];
			Cards[b] = temp;
		}
	}

}
