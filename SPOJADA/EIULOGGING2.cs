//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIULOGGING2
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            int input = reader.NextInt();
//            long num1 = 0;
//            long num2 = 0;
//            long num3 = maxValue(num1, num2, reader.NextInt());
//            long result = num3;

//            for (int i = 1; i < input; i++)
//            {
//                result = maxValue((num1 + reader.NextInt()), num2, num3);
//                num1 = num2;
//                num2 = num3;
//                num3 = result;
//            }
//            Console.WriteLine(result);
//        }

//        static long maxValue(long max, long v1, long v2)
//        {
//            max = max > v1 ? max : v1;
//            max = max > v2 ? max : v2;
//            return max;
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
