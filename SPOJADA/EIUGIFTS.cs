//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIUGIFTS
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            int noOfGifts = reader.NextInt();
//            long money = reader.NextLong();
//            long[] giftList = new long[noOfGifts];

//            for (int index = 0; index < noOfGifts; index++)
//            {
//                giftList[index] = reader.NextLong();
//            }
//            Array.Sort(giftList);
//            int i = 0;
//            int j = giftList.Length - 1;
//            long total = 0;
//            long difference = -1;
//            long endResult = -1;
//            while (i < j)
//            {
//                total = giftList[i] + giftList[j];
//                if (total <= money)
//                {
//                    if (total >= endResult)
//                    {
//                        endResult = total;
//                        difference = giftList[j] - giftList[i];
//                    }
//                    i++;
//                }
//                else if (total > money)
//                {
//                    j--;
//                }
//            }
//            Console.WriteLine(endResult + " " + difference);
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
//        public long NextLong()
//        {
//            return long.Parse(Next());
//        }
//        public double NextDouble()
//        {
//            return double.Parse(Next());
//        }
//    }
//}
