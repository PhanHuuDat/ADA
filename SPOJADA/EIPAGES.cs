//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIPAGES
//    {
//        static StringBuilder result = new StringBuilder();
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            int noOfPages = reader.NextInt();
//            int[] pages = new int[noOfPages];

//            for (int i = 0; i < pages.Length; i++)
//            {
//                pages[i] = reader.NextInt();
//            }
//            Array.Sort(pages);
//            result.Append(pages[0]);
//            int index = 0;
//            for (int i = 1; i < pages.Length; i++)
//            {
//                int pageLength = pages[i] - pages[i - 1];
//                if (pageLength != 1)
//                {
//                    if (index > 1)
//                    {
//                        result.Append("-").Append(pages[i - 1]);
//                    }
//                    else if (index == 1)
//                    {
//                        result.Append(" ").Append(pages[i - 1]);
//                    }
//                    result.Append(" ").Append(pages[i]);
//                    index = 0;
//                }
//                else if (pageLength == 1)
//                {
//                    index++;
//                }

//            }
//            if (index > 1)
//            {
//                result.Append("-").Append(pages[pages.Length - 1]);
//            }
//            else if (index == 1)
//            {
//                result.Append(" ").Append(pages[pages.Length - 1]);
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
