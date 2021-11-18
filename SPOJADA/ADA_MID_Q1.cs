//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class ADA_MID_Q1
//    {
//        static Reader reader = new Reader();

//        static void Main(string[] args)
//        {
//            int arrayLength = reader.NextInt();
//            int pair = reader.NextInt();
//            List<int> list = new List<int>();
//            int result = 0;
//            Dictionary<int, int> valuePairs = new Dictionary<int, int>();
//            for (int i = 0; i < arrayLength; i++)
//            {
//                int number = reader.NextInt();
//                int diff = number - pair;
            
//                if (valuePairs.TryGetValue(diff, out int value))
//                {
//                    result += value;
//                }
//                if (!valuePairs.TryGetValue(number, out value))
//                {
//                    valuePairs[number] = 1;
//                }
//                else
//                {
//                    valuePairs[number] += 1;
//                }
//            }

//            Console.WriteLine(result);
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
