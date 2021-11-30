//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIUGAME
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            int col = reader.NextInt();
//            long[] matrix = new long[reader.NextLong() + 1];
//            long number1;
//            long number2;
//            matrix[0] = 0;

//            for (int i = 1; i < matrix.Length; i++)
//            {
//                matrix[i] = matrix[i - 1] + reader.NextInt();
//            }
//            for (int index = 1; index < col; index++)
//            {
//                matrix[1] += reader.NextLong();
//                for (int i = 2; i < matrix.Length; i++)
//                {
//                    long number = reader.NextLong();
//                    number1 = matrix[i - 1] + number;
//                    number2 = matrix[i] + number;
//                    matrix[i] = number1>number2?number1:number2;

//                }
//            }

//            Console.WriteLine(matrix[matrix.Length - 1]);
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
