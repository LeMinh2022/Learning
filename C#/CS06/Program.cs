using System;

namespace CS06{
    class Program{
        static void Main(string[] args){
            // int a=10;

            // switch (a){
            //     case 1:
            //     Console.WriteLine(" Gia tri a bang mot");
            //     break;
            //     case 2:
            //     Console.WriteLine(" Gia tri a bang hai");
            //     break;
            //     case 3:
            //     Console.WriteLine(" Gia tri a bang ba");
            //     break;
            //     case 4:
            //     Console.WriteLine(" Gia tri a bang bon");
            //     break;

            //     default: 
            //     Console.WriteLine("hay thu so khac");
            //     break;
            // }

            int a,b;
            Console.WriteLine("nhap so a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so b:");
            b = int.Parse(Console.ReadLine());

            L1:
            Console.WriteLine("hay chon lenh");
            Console.WriteLine(" 1. tinh tong");
            Console.WriteLine(" 2. tinh hieu");
            Console.WriteLine(" 3. tinh tich");
            Console.WriteLine(" 4. tinh thuong");

            char c;
            c= Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (c) {
                case '1':
                 Console.WriteLine($"Tong la: {a+b}");
                break;
                case '2':
                 Console.WriteLine($"Hieu la: {a-b}");
                break;
                case '3':
                 Console.WriteLine($"tichla: {a*b}");
                break;
                case '4':
                 Console.WriteLine($"Thuonng la: {a/b}");
                break;

                default: 
                Console.WriteLine("hay chon lenh khac");
                goto L1;
                break;
            }
        }
    }
}

