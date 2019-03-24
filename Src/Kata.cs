using System;
using System.Linq;
using System.Collections.Generic;

namespace Src
{
    public static class Kata
    {
        public static int Score(int[] dice) 
        {
            var score = 0;
            var scoreTable = new Dictionary<int, int> {
                {1, 1000},
                {6, 600},
                {5, 500},
                {4, 400},
                {3, 300},
                {2, 200}
            };

            for(int i = 1; i < 7; i++)
            {
                if(dice.Count(d => d == i) >= 3)
                {
                    score += scoreTable[i];

                    for(int j = 0; j < 3; j++)
                    {
                        dice[Array.IndexOf(dice, i)] = 0;
                    }
                }
            }

            score += dice.Count(d => d == 1) * 100;
            score += dice.Count(d => d == 5) * 50;

            return score;
        }
    }
}
