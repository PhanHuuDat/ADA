//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIUCONS
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            long noOfLocation = reader.NextInt();
//            long res = 0;
//            long largest = 0;
//            for (int i = 0; i < noOfLocation; i++)
//            {
//                long Ni = reader.NextInt();
//                long A = reader.NextInt();
//                long B = reader.NextInt();
//                long temp = A % B;
//                largest = temp;
//                for (int j = 1; j < Ni; j++)
//                {
//                    temp = (temp * A) % B;
//                    largest = largest > temp ? largest : temp;
//                }
//                res += largest;
//            }
//            Console.WriteLine(res);
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
