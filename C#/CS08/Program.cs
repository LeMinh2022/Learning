using System;
using System.Linq;

namespace CS08{
    class Program{
        static void Main(string[] agrs){
            // string sinhvien1 = "nguyen van A";
            // string sinhvien2 = "nguyen van A";
            // string sinhvien3 = "nguyen van A";

            // string[] ds;
            // ds = new string[3];
            // ds[0] = "nguyen van a";
            // ds[1] = "nguyen van b";
            // ds[2] = "nguyen van c";

            // for (int i = 0; i <= 2; i++)
            // {
            //     Console.WriteLine(ds[i]);
            // }

             //-----------------------------------------------------//

            // khai bao mang 
            // int[] mangsonguyen;
            // string[] mang1;
            // double[] mang2 = {2,3.5,6.4};

            // // tao mang biet truoc so phan tu
            // mangsonguyen = new int[3];

            // string[] mang2phantu = new string[1];

            // mangsonguyen[0] = 1;
            // mangsonguyen[1] = 2;
            // mangsonguyen[2] = 3;


             //-----------------------------------------------------//


            // // khai bao gan bien cho mang luon

            // mang1 = new string[3] {"2","ok","3"};

            // int[] numbers = {1,2,34,3,34,2,2};

            // int sophantu = numbers.Length;

            // // dung vong for de in ra phan tu trong mang
            // for (int chiso = sophantu-1; chiso >= 0; chiso--)
            // {
            //     Console.WriteLine(numbers[chiso]);   
            // }

            // // diet theo tung ohan tu trong mang
            // foreach (var abc in numbers)
            // {
            //     Console.WriteLine(abc);
            // }

            //-----------------------------------------------------//

            //phuong thuc cua lop array

            // int[] numbers = {1,2,34,3,34,2,2};

            // Console.WriteLine($"so phan tu: {numbers.Length}");
            // Console.WriteLine($"so chieu mot mang: {numbers.Rank}");
            // Console.WriteLine($"min: {numbers.Min()}");
            // Console.WriteLine($"max: {numbers.Max()}");
            // Console.WriteLine($"tong: {numbers.Sum()}");
            
            // Array.Sort(numbers);

            // foreach (var item in numbers)
            // {
            //     Console.WriteLine(item);
            // }

            //-----------------------------------------------------//

            //mang nhieu chieu

            double[,] numbers = new double[2,3] {{2,4,54}, {24,12,1}};

            Console.WriteLine(numbers[0,2]);

            int hang = 2;
            int cot =3;

            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.WriteLine(numbers[i,j]);
                    Console.WriteLine(" ");
                }

                Console.WriteLine();
            }
        }
    }
}

