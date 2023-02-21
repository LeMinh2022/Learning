using System;

namespace Cs07 {
    class Program {
        static void Main(string[] args){
            /*
            for (khoi_tao; dieu_kien; cap_nhat){
                // cac cau lenh
            }
            */
            for (int i =1; i <=10; i++){
                Console.WriteLine($"i = {i}");
                Console.WriteLine("Hello world");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($" 3 x {i} = {3 * i}");
            }

            int j =1000;

            // do white 

            do 
            {
                Console.WriteLine($" 3 x {j} = {3*j}");
                j++;
            }
            while (j < 10);

            // break and contine

            int e =1;

            while(e < 100)
            {
                Console.WriteLine($" 3 x {e} = {3*e}");
                e++;
                if ( e == 5)
                {
                    break;
                }
            }
            
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 !=0) continue;

                Console.WriteLine($"so i la {i}");
            }


        }
    }
}

