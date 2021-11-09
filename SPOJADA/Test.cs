//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class Test
//    {
//        static Reader reader = new Reader();
//        static StringBuilder result = new StringBuilder();

//        static void Main(string[] args)
//        {
//            int noOfEggs = reader.NextInt();

//            int days = 0;
//            int totalEggs = 0;

//            while (totalEggs < noOfEggs)
//            {
//                totalEggs += (1 << days);
//                days++;
//            }
//            Console.WriteLine(days + " " + totalEggs);
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
