using System;

namespace CS03{

    class Program {

        static void Main (string[] args){

            // Toán tử cố học 
            // + - * / %
            float a = 5;
            int b = 4;

            Console.WriteLine("a + b = {0}", a+b);
            Console.WriteLine("a - b = {0}", a-b);
            Console.WriteLine("a * b = {0}", a*b);
            Console.WriteLine("a / b = {0}", a/b);
            Console.WriteLine("a % b = {0}", a%b);

            float kq = 6/2 + 3 *3;
            Console.WriteLine(kq);

            // toán tử gán 
            // = += -= *= /= %= -- ++
            int x;
            x = 13;
            float y; 
            y = 1 + 3 +4;
            Console.WriteLine("gia tri cua y");
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y -= 7;
            Console.WriteLine(y);
            y /= 6;
            Console.WriteLine(y);
            y++;
            Console.WriteLine(y);

            // nhan truoc roi moi + 1
            y = 2 * y++;
            Console.WriteLine(y);
        }       
    }
}


