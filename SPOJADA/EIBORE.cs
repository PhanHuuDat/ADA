//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIBORE
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            int noOfNumber = reader.nextInt();
//            Dictionary<int, int> dict = new Dictionary<int, int>();
//            List<int> key = new List<int>();
//            long num1;
//            long num2;
//            long max;
//            for (int i = 0; i < noOfNumber; i++)
//            {
//                int number = reader.nextInt();
//                if (dict.TryGetValue(number, out int value))
//                {
//                    dict[number] = value + number;
//                }
//                else
//                {
//                    dict[number] = number;
//                    key.Add(number);
//                }
//            }
//            key.Sort();

//            num1 = 0;
//            num2 = Math.Max(num1, dict[key[0]]);
//            max = num2;

//            for (int i = 1; i < key.Count; i++)
//            {
//                max = Math.Max((dict[key[i]]) + (key[i - 1] + 1 == key[i] ? num1 : num2), num2);
//                num1 = num2;
//                num2 = max;
//            }

//            Console.WriteLine(num2);


//        }
//    }

//    class Reader
//    {
//        private int index = 0;
//        private string[] tokens;
//        public string next()
//        {
//            while (tokens == null || tokens.Length <= index)
//            {
//                tokens = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
//                index = 0;
//            }
//            return tokens[index++];
//        }

//        public int nextInt()
//        {
//            return int.Parse(next());
//        }
//        public long nextLong()
//        {
//            return long.Parse(next());
//        }
//        public double nextDouble()
//        {
//            return double.Parse(next());
//        }
//    }

//}
