//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class Logging
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            int input = reader.NextInt();


//            long num1 = 0;
//            long num2 = Math.Max(num1, reader.NextInt());
//            long result = num2;

//            for (int i = 1; i < input; i++)
//            {
//                result = Math.Max((num1 + reader.NextInt()), num2);
//                num1 = num2;
//                num2 = result;
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
