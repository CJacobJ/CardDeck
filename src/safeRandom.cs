/*		safeRandom.cs
**
*/
using System;

namespace SafeRandom
{
	/*********************************************************************
	 * @brief Thread safe random numbers.
	 * @details Stores a seperate random object for each thread being used.
	 *********************************************************************/
	public class SafeRandomGen
	{
		private static readonly Random globRand = new Random();		//!< The global random object used to seed the local randoms
		[ThreadStatic] private static Random rand;		//!< Random object local to each thread

		/*********************************************************************
		 * @brief Picks a new random int.
		 * @details Picks a random int lower than max.
		 * @param max Total number of ints to pick from
		 * @return Returns value from zero to max - 1
		 *********************************************************************/
		public static int NextRand(int max)
		{
			if(rand is null)
			{
				lock (globRand)
				{
					rand = new Random(globRand.Next());
				}
			}
			return rand.Next(max);
		}

	}
}
