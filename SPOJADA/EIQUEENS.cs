//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{
//    class EIQUEENS
//    {
//        static Reader reader = new Reader();
//        static void Main(string[] args)
//        {
//            List<Location> list = new List<Location>();
//            for (int i = 1; i < 9; i++)
//            {
//                string input = reader.Next();
//                if (input.IndexOf("*") != -1)
//                {
//                    Location location = new Location(i, input.IndexOf("*") + 1);
//                    list.Add(location);
//                }
//            }
//            string result = "valid";
//            if (list.Count != 8)
//            {
//                result = "invalid";
//            }
//            else
//            {
//                for (int i = 0; i < list.Count; i++)
//                {
//                    for (int j = i + 1; j < list.Count; j++)
//                    {
//                        int isX = Math.Abs(list[i].x - list[j].x);
//                        int isY = Math.Abs(list[i].y - list[j].y);
//                        if (list[i].x == list[j].x || list[i].y == list[j].y || isX == isY)
//                        {
//                            result = "invalid";
//                        }
//                    }
//                }
//            }
            
//            Console.WriteLine(result);
//        }
//    }

//    class Location
//    {
//        public int x;
//        public int y;

//        public Location(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
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
