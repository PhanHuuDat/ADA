//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIFREEZER
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            int liter = reader.NextInt();
//            int a = 1;
//            int b = 1;
//            int c = liter; 
//            int temp;
//            for (int i = 1; i <= Math.Cbrt(liter); i++)
//            {
//                if (liter % i == 0)
//                {
//                    temp = liter / i;
//                    for (int j = i; j <= Math.Sqrt(temp); j++)
//                    {
//                        if (temp % j == 0)
//                        {                         
//                            a = i;
//                            b = j;
//                            c = temp / j;
//                        }
//                    }
//                }
//            }
//            Console.WriteLine(c + " " + b + " " + a);
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
