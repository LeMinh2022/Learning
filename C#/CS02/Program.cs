using System;

namespace CS02{
    class Program{
        static void Main (string[] args){

            /* 1 - biến và kiểu dữ liệu
            Kieu_du_lieu Ten_bien
            Ten_bien
            - a..z A..Z
            - 0 .. 9
            - cach nhau bang _
            - Khong bat dau bang so
            - Khong chua cac kieu chu dac biet

            Truoc khi su dung can gan gia tri cho bien
            gán giá trị bằng dấu = 
            */

        // khởi tạo một biến student_Name gán giá trị bằng abc
            string student_Name= "abc";
        // khỏi tạo biến Student_Age với kiểu giữ liệu int 
            int student_Age;

            char a; 

            float c; 

            c = (float)12.12;

            object d;

            d = student_Name;

            // khai báo biến so_pi kiểu giữ liệu double
            double so_pi;
            so_pi = 3.14;

            // khai báo biến hai_pi kiểu giữ liệu double
            double hai_pi;
            hai_pi = 2 * so_pi;

            Console.WriteLine(hai_pi);

            
            //-----------------------------------------------//



            // 2 lớp Console là lớp static của c# để giao tiếp với cửa sổ console

            Console.Title = "vi du ve console";
            Console.Clear();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" xin chao chuong trinh nhap xuat console");
            Console.WriteLine();
            

            // màu chữ cửa sổ console
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            
            Console.ReadKey();

            Console.Write("Gia tri cua so pi:");
            Console.Write(so_pi);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("mau chu ve nhu cu");

            // người cùng nhập dữ liệu vào 
            string hovaten;

            Console.WriteLine("Ho ten cua ban: ");
            hovaten = Console.ReadLine();
            Console.WriteLine("Xin Chao {0}", hovaten);

            float f , b; 
            string sinput;
            
            Console.WriteLine("Hay nhap tham so f:");
            sinput = Console.ReadLine();
            f = float.Parse(sinput);

            Console.WriteLine("Hay nhap tham so b:");
            sinput = Console.ReadLine();
            b = Convert.ToSingle(sinput);

            Console.WriteLine("so a = {0} , b = {1} ", f, b);


        }
    }
}

