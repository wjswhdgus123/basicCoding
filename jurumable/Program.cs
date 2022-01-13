using System;

namespace jurumable
{
    class Program
    {
        static void Main(string[] args)
        {

            int dice=DICE();
            int map = CreateMAP();
            Console.WriteLine(dice);

            int jjh_map = map;
            int hanbin_map = map;
            int soju = happy_soju(0);

            Console.WriteLine(hanbin_map);
            Console.WriteLine(soju);












        }

        static int CreateMAP()
        {
            Random MAP = new Random();
            int map = MAP.Next(15, 45);



           
            return map;
        }
        static int DICE()
        {
            Random rand = new Random();
            int map = rand.Next(1, 5);

        

            return map;
        }

        static int happy_soju(int fail_input)
        {
            if (fail_input == 0)
            {
                Random SOJU = new Random();
                int fail_soju = SOJU.Next(1, 4);

                return fail_soju;
            }

            else
            {
                int fail_soju = 0;
                return fail_soju;
            }

            

        }
        
    }
}
