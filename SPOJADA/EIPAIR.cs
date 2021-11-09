//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SPOJADA
//{
//    class EIPAIR
//    {
//        static Reader reader = new Reader();
//        static StringBuilder result = new StringBuilder();
//        static void Main(string[] args)
//        {
//            int noOfTestcases = reader.NextInt();
//            for (int i = 0; i < noOfTestcases; i++)
//            {
//                Dictionary<long, long> duplicate = createList();
//                long totalChoice = 0;
//                foreach (int key in duplicate.Keys)
//                {
//                    if (duplicate[key] != 1)
//                    {
//                        totalChoice += combination(duplicate[key], 2);
//                    }
//                }
//                result.Append(totalChoice).Append("\n");
//            }
//            Console.WriteLine(result);
//        }

//        static Dictionary<long, long> createList()
//        {
//            Dictionary<long, long> duplicate = new Dictionary<long, long>();

//            int noOfGifts = reader.NextInt();

//            for (int i = 0; i < noOfGifts; i++)
//            {
//                int giftPrice = reader.NextInt();
//                if (!duplicate.ContainsKey(giftPrice))
//                {
//                    duplicate.Add(giftPrice, 1);
//                }
//                else
//                {
//                    duplicate[giftPrice] += 1;
//                }
//            }
//            return duplicate;
//        }

//        static long combination(long n, int k)
//        {

//            long total = (n * (n - 1)) / 2;
//            return total;
//        }
//    }

//    class Reader
//    {
//        private int index = 0;
//        private string[] tokens;
//        public string Next()
//        {
//            while (tokens == null || tokens.Length <= index)
//            {
//                tokens = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
//                index = 0;
//            }
//            return tokens[index++];
//        }

//        public int NextInt()
//        {
//            return int.Parse(Next());
//        }

//        public double NextDouble()
//        {
//            return double.Parse(Next());
//        }
//    }
//}
