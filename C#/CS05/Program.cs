using System;

namespace CS05{
    class Program {
        static void Main(string[] agrs){
            /**
            if (dieu kienlogic){
                dong lenh
            }
            else {
                dong lenh
            }
            **/

            // int a;
            // Console.WriteLine("nhap so nguyen a: ");
            // a = int.Parse(Console.ReadLine());
            // if (a %2 ==0){
            //     Console.WriteLine(" ket qua");
            //     Console.WriteLine($" So {a} la co chan");
            // } else{
            //     Console.WriteLine(" ket qua");
            //     Console.WriteLine($" So {a} la co le");
            // }

            // Console.WriteLine("the end");

            // /*
            // [8-10]: gioi
            // [6.5 -8]: kha
            // [5.0-6.5: trung binh]
            // [0-5.0]: yeu
            // */
            // float x; 
            // Console.WriteLine("nhap so diem hoc sinh:");
            // x = float.Parse(Console.ReadLine());
            // if (x < 5 && x>0){
            //     Console.WriteLine("em dat hoc luc yeu.");
            // } else if( x < 6.5 )
            // {
            //     Console.WriteLine("em dat hoc luc trung binh.");
            // } else if(  x < 8 )
            // {
            //     Console.WriteLine("em dat hoc luc kha.");
            // } else if( x < 10 )
            // {
            //     Console.WriteLine("em dat hoc luc gioi.");
            // } else {
            //     Console.WriteLine(" vui long nhap lai so diem hop le (tu 0d den 10d)");
            // }

            // Console.WriteLine("the end");


            // toan tu 3 ngoi 
            // (dieu kien) ? bieu thuc 1 : bieu thuc 2
            // float c ,d;
            // Console.WriteLine("nhap so c:");
            // c = float.Parse(Console.ReadLine());

            // Console.WriteLine("nhap so c:");
            // d = float.Parse(Console.ReadLine());
            
            // float max; 

            // max = (c>d) ? c : d;
            // Console.WriteLine(" so lon nhat la {0}", max);

            float a =20 , b = 3.5f, c =10 ;

            float max; 

            max = (a > b) ? a : b;
            max = (max > c) ? max : c;
            Console.WriteLine(" so lon nhat la {0}", max);

            max = (a > b) ? ( a > c) ? a : c : (b > c) ? b : c;


        }
    }
}

