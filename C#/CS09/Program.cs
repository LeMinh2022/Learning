using System;

namespace CS09 {
    class Program {
        static void Main(string[] args){
            
        //     // goi den phuong thuc xin chao
        //     //cach day du
        //     // CS09.program.xinchao();
        //     // cach goi ngan neu cung mot namespace
        //     xinchao();
        //     tich(3,4);
        //     int ketqua;

        //     ketqua = tich(3,2);

        //     Console.WriteLine(ketqua);

        //     ketqua = TinhToan.Tong(123,245);

        //     Console.WriteLine(ketqua);

        //     int x = 123;
        //     int y = 11;

        //     ketqua = TinhToan.Tong(x,y);

        //     Console.WriteLine(ketqua);

        // }

        // // khai bao phuong thuc xinchao
        // static void xinchao(){
        //     Console.WriteLine("=========================");
        //     Console.WriteLine("xin chao");
        // }

        // // cau truc khai bao bien
        // // <Access Modifiers> <return type> <name_method> (<parameter>)
        // //{
        //     // cac au lenh cua phuong thuc
        // //}

        // /*
        //     <Access Modifiers> = pham vi truy cap cau phuong thuc
        //     public cho phep ben ngoai lop suwr dung
        //     private chi cho phep dung ben trong phuong thuc
        //     proteced chi dung trong lop va cac lop ke thua

        //     <return type> = kieu gia trị tra ve

        // */

        // public static int tich(int a ,int b){
        //     int result;
        //     result = a*b;
        //     return result;
        // }

        // tham chieu tham tri 
        
        int a; 
        binhphuong(4, out a);
        Console.WriteLine(a);
        }

        static void binhphuong(int x , out int kq){
            kq = x *x; 
        }
    }
}