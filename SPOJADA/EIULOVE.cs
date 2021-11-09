//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{

//    class EIULOVE
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            int noOfGifts = reader.NextInt();
//            long money = reader.NextLong();
//            int perfectGift = 0;
//            ArrayList giftList = new ArrayList();
//            for (int i = 0; i < noOfGifts; i++)
//            {
//                int giftPrice = reader.NextInt();
//                if (giftPrice > perfectGift && giftPrice < money)
//                {
//                    perfectGift = giftPrice;
//                }
//                else if (giftPrice == money)
//                {
//                    perfectGift = giftPrice;
//                    break;
//                }
//            }
//            perfectGift = perfectGift == 0 ? -1 : perfectGift;
//            Console.WriteLine(perfectGift);
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
