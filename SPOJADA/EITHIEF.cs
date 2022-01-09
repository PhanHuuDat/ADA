//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EITHIEF
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {           
//            long[] maxValues = new long[reader.NextInt() + 1];
//            int maxWeight = reader.NextInt();
            
//            Array.Fill(maxValues, 0);

//            for (int i = 0; i < maxValues.Length - 1; i++)
//            {
//                int weight = reader.NextInt();
//                int value = reader.NextInt();
//                for (int j = maxWeight; j >= weight; j--)
//                {
//                    maxValues[j] = Math.Max(maxValues[j], maxValues[j - weight] + value);
//                }
//            }
//            Console.WriteLine(maxValues[maxValues.Length - 1]);
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
