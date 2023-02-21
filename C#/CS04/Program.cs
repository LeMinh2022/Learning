using System;

namespace CS04{

    class Program{

        static void Main(string[] args){
            bool isOnline;
            isOnline = false;
            Console.WriteLine(isOnline);

            //phep toan so sanh
            // == > < >= <= !=
            int a =6;
            int b= 7;
            bool kq;

            kq = a ==b;
            Console.WriteLine(" a == b --> {0}",kq);
            Console.WriteLine($" a != b --> {a!=b}",kq);

            // && || !

            bool x = false;
            bool y = true;

            Console.WriteLine(x || y);
            Console.WriteLine(x && y);

        }
    }
}

