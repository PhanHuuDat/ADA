using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJADA
{
    class EIJUMP
    {
        static Reader reader = new Reader();
        static void Main(string[] args)
        {
            int[] stones = new int[reader.NextInt()];
            int[] steps = new int[stones.Length];
            steps[0] = 0;
            Dictionary<int, int> dictStones = new Dictionary<int, int>();
            int smallestStep = stones.Length;
            int currentStep = 0;

            for (int i = 0; i < stones.Length; i++)
            {
                int stone = reader.NextInt();
                stones[i] = stone;
                if (!dictStones.ContainsKey(stone))
                {
                    dictStones[stone] = 1;
                }
                else
                {
                    dictStones[stone] += 1;
                }
            }
            
            for (int i = 1, j = 1; i < stones.Length; i++)
            {
                currentStep = i;
                if (dictStones[stones[j]] == 1)
                {
                    steps[i] = steps[i - 1] + 1;
                }
                else
                {
                    currentStep += dictStones[stones[j]] - 1;
                    j = Array.FindIndex(stones, j, a => a == stones[j]);

                }
                if (currentStep > smallestStep)
                {
                    break;
                }
                smallestStep = smallestStep < currentStep ? smallestStep : currentStep;
            }

            Console.WriteLine(smallestStep);

        }
    }

    class Reader
    {
        private int index = 0;
        private string[] tokens;
        public string Next()
        {
            while (tokens == null || tokens.Length <= index)
            {
                tokens = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                index = 0;
            }
            return tokens[index++];
        }

        public int NextInt()
        {
            return int.Parse(Next());
        }
        public long NextLong()
        {
            return long.Parse(Next());
        }
        public double NextDouble()
        {
            return double.Parse(Next());
        }
    }

}
