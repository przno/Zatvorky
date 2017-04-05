using System;

namespace Zatvorky
{
    public class Program
    {
        static void Main(string[] args)
        {
            // manualne testuj tu ale radsej si kukni unit test
            Console.WriteLine(FindPosition("(())()))(((())((()()()))"));
            Console.ReadKey();
        }

        public static int FindPosition(string str)
        {
            int index_left = 0;
            int index_rigth = str.Length;
            bool moveLeftToRight = true;

            for (; index_left != index_rigth;)
            {
                Console.WriteLine("DEBUG: index_left={0}, index_right={1}", index_left, index_rigth);
                
                if (moveLeftToRight)
                {
                    if(str[index_left] == '(')
                    {
                        moveLeftToRight = !moveLeftToRight;
                        index_rigth--;
                    }
                    else
                    {
                        index_left++;
                    }
                }
                else
                {
                    if (str[index_rigth] == ')')
                    {
                        moveLeftToRight = !moveLeftToRight;
                        index_left++;
                    }
                    else
                    {
                        index_rigth--;
                    }
                }
            }

            return index_left;
        }
    }
}
