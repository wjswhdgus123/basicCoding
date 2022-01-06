using System;

namespace testcode_20211223
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now; 
            Console.WriteLine(date);
            Console.WriteLine(date.Date);

            int a = 3;
            int b = 10;
            Console.WriteLine(swap(a,b));

          
        (int,int) swap(int x, int y)
            {
               int tmp = 0;
                tmp = y;
                y = x;
                x = tmp;
                tmp = 0;






                return (x, y);
            }

         
        }
        
        
      
    }
}
