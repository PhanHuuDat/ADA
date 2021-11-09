//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SPOJADA
//{

//    class EIBORROW
//    {
//        static Reader reader = new Reader();
//        static StringBuilder result = new StringBuilder();
//        static void Main(string[] args)
//        {
//            int noOfTestcases = reader.NextInt();

//            string game;
//            int tuan = 0;
//            int hang = 0;

//            for (int i = 0; i < noOfTestcases; i++)
//            {
//                game = reader.Next();
//                int sc = gameGoals(game);
//                if (sc==1)
//                {
//                    tuan++;
//                }
//                else if(sc==0)
//                {
//                    hang++;
//                }
//            }
//            Console.WriteLine(hang + " " + tuan);
//        }

//        static int gameGoals(string game)
//        {
//            int tuan = 0;
//            int hang = 0;

//            for (int i = 0; i < game.Length; i++)
//            {
//                if (game.Substring(i, 1).Equals("H"))
//                {
//                    hang++;
//                }
//                else
//                {
//                    tuan++;
//                }
//            }

//            if (tuan > hang)
//            {
//                return 1;
//            }
//            else if (tuan < hang)
//            {
//                return 0;
//            }
//            else return -1;
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
