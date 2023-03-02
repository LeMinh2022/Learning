using System;

namespace CS11{
    class Program {
        static void Main(string[] asgr){

            // // khai bao chuoi 
            // string loichao;
            // loichao = " Xin chao";
            // string ten = "okanh em";
            // string thongbao = loichao + " " + ten;
            // Console.WriteLine(thongbao);

            // // them gia tri cho chuoi
            // thongbao += "!";
            // Console.WriteLine(thongbao);

            // // chen ky tu dau nhay kep
            // // \\ \t \n \r  \"
            // thongbao = " chen ky tu \\  \"String\" ";
            // Console.WriteLine(thongbao);

            // // chuoi co @ 
            // thongbao = @"truong hop @ ""2012""
            
            // xuong dong ";
            // Console.WriteLine(thongbao);

            // // them gia tri vao chuoi 
            // int year = 2023;
            
            // thongbao = $" xin chao {year, 10}, nawm sau la nam {year + 1}";
            // Console.WriteLine(thongbao);

            string thongbao = "xin chao anh em";

            // int dodai =  thongbao.Length;
            
            // // bien c = gia tri ky tu thu 4 trong chuoi
            // char c = thongbao[4];

            Console.WriteLine(thongbao);
            // Console.WriteLine(dodai);
            // Console.WriteLine(c);

            // for(int i = 0; i < dodai; i++){
            //     char cd = thongbao[i];
            //     Console.WriteLine(cd);
            // }

            // foreach (var kytu in thongbao)
            // {
            //     Console.WriteLine(kytu);
            // }

            thongbao= thongbao.Trim();
            Console.WriteLine(thongbao);

            // tim kiem va thay the chuoi con trong 
            thongbao = thongbao.Replace("xin chao","ok");
            Console.WriteLine(thongbao);

            // them ky tu 
            thongbao = thongbao.Insert(0 , "2023");
            Console.WriteLine(thongbao);

            // xoa 
            thongbao = thongbao.Remove(6, 4);
            Console.WriteLine(thongbao);

            // chia chuoi con
            string[] thongbaonho = thongbao.Split(' ');

            foreach (var CHUOI in thongbaonho)
            {
                Console.WriteLine(CHUOI);
            }

            Console.WriteLine(thongbao);

            // gop mang thanh chuoi

            string[] mang = {"okasd", "2sjdf"};

            thongbao = string.Join(".", mang);
            Console.WriteLine(thongbao); 
        }
    }
}

