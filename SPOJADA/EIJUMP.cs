//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace spojada
//{
//    class EIUJUMP
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            int[] stones = new int[reader.nextInt()];
//            int[] steps = new int[stones.Length];

//            Dictionary<int, int> dictstones = new Dictionary<int, int>();

//            for (int i = 0; i < stones.Length; i++)
//            {
//                stones[i] = reader.nextInt();
//                steps[i] = stones.Length;               
//            }
//            steps[0] = 0;
//            dictstones[stones[0]] = 0;
//            for (int i = 1; i < stones.Length; i++)
//            {
//                if (steps[i] > steps[i-1] + 1)
//                {
//                    steps[i] = steps[i-1] + 1;
//                }
//                if (dictstones.TryGetValue(stones[i], out int location))
//                {
//                    if (steps[i] > steps[location] + 1)
//                    {
//                        steps[i] = steps[location] + 1;
//                    }
//                }                
//                dictstones[stones[i]] = i;
//            }
//            Console.WriteLine(steps[steps.Length - 1]);
//        }
//    }

//    class Reader
//    {
//        private int index = 0;
//        private string[] tokens;
//        public string next()
//        {
//            while (tokens == null || tokens.Length <= index)
//            {
//                tokens = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
//                index = 0;
//            }
//            return tokens[index++];
//        }

//        public int nextInt()
//        {
//            return int.Parse(next());
//        }
//        public long nextLong()
//        {
//            return long.Parse(next());
//        }
//        public double nextDouble()
//        {
//            return double.Parse(next());
//        }
//    }

//}
