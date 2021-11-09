using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJADA
{
    class EIPMOD
    {
        static Reader reader = new Reader();

        static void Main(string[] args)
        {
            long x = reader.NextInt();
            long n = reader.NextLong();
            long k = reader.NextInt();
            Dictionary<long, long> powMod = new Dictionary<long, long>();
            List<long> keyList;
            long i = 2;
            powMod.Add(1, x % k);
            while (i < n)
            {
                x = (x * x) % k;
                powMod.Add(i, x);
                i = i << 1;
            }
            keyList = new List<long>(powMod.Keys);
            i = i >> 1;
            long flag = i;
            int j = keyList.Count - 1;
            if (n != 0)
            {
                while (n != flag)
                {
                    i = n - flag;                
                    while (j >= 0)
                    {
                        if (keyList[j]<=i)
                        {
                            x = (x * powMod[keyList[j]]) % k;
                            flag += keyList[j];
                            break;
                        }
                        else
                        {
                            j--;
                        }
                    }
                }
            }
            else
            {
                x = 1;
            }

            Console.WriteLine(x);

        }
    }

    class Reader
    {
        private int index = 0;
        private string[] tokens;
        public string Next()
        {
            while (tokens == null || tokens.Length <= index)
            {
                tokens = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                index = 0;
            }
            return tokens[index++];
        }

        public int NextInt()
        {
            return int.Parse(Next());
        }
        public long NextLong()
        {
            return long.Parse(Next());
        }
        public double NextDouble()
        {
            return double.Parse(Next());
        }
    }
}
