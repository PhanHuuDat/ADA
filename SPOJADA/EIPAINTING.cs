//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIPAINTING
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            int noOfArt = reader.NextInt();
//            int happiness = 0;
//            int result;
//            Dictionary<int, int> artList = new Dictionary<int, int>();
//            for (int i = 0; i < noOfArt; i++)
//            {
//                int temp = reader.NextInt();
//                if (artList.ContainsKey(temp))
//                {
//                    artList[temp] += 1;
//                }
//                else
//                {
//                    artList.Add(temp, 1);
//                }
//                happiness = happiness < artList[temp] ? artList[temp] : happiness;
//            }
//            result = noOfArt - happiness;
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
