using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveVsFriendship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WordsToMarks("wffnjmavridngwunpld"));
            Console.ReadLine();
        }
       /* array(
    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
    's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
);*/

        public static int WordsToMarks(string str)
        {
            int result = 0;
            char[] chars = str.ToCharArray();
            char[] words = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
    's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};            
          
               
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (chars[i]==words[j])
                    {
                        result += j+1;
                    }
                }
            }

            return result;
        }

        public static int WordsToMarks1(string str)
        {
            int sum = 0;
            // 'a' has 97 int representation in Unicode table, so we minus 96 to get 'a' equal to 1
            int charSpace = 96;

            foreach (char letter in str)
            {
                sum += letter - charSpace;
            }

            return sum;
        }

        public static int WordsToMarks2(string str)
        {
            Dictionary<char, int> abcDic = new Dictionary<char, int>();
            string abc = "abcdefghijklmnopqrstuvwxyz";
            List<int> selectedList = new List<int>();
            int counter = 1;

            foreach (char c in abc)
                abcDic.Add(c, counter++);

            foreach (char b in str)
            {
                foreach (var a in abcDic)
                {
                    if (b == a.Key)
                        selectedList.Add(a.Value);
                }
            }



            return selectedList.Sum();
        }
    }
}
