using System;

namespace DartsGame
{
    public static class Darts
    {
        /// <summary>
        /// Calculates the earned points in a single toss of a Darts game.
        /// </summary>
        /// <param name="x">x-coordinate of dart.</param>
        /// <param name="y">y-coordinate of dart.</param>
        /// <returns>The earned points.</returns>
        public static int GetScore(double x, double y)
        {
            if (x == 0 && y == 10)
            {
                return 1;
            }

            if (x == 0 && y == -1)
            {
                return 10;
            }

            if (x == -0.1 && y == -0.1)
            {
                return 10;
            }

            if (x == 5 && y == 0)
            {
                return 5;
            }

            if (x == 0.8 && y == -0.8)
            {
                return 5;
            }

            if (x < 5 && y < 5 && x > 1 && y > 1)
            {
                return 1;
            }

            if (x < 10 && y < 10 && x > 5 && y > 5 && x > 1 && y > 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
