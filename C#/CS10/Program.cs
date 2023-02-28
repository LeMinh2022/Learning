using System;
namespace CS10{

    // phuong thuc huy 
    class Student {
        public string name;

        public Student(string name){
            this.name = name;
            Console.WriteLine("khoi tao" + name);
        }
        ~Student(){
            Console.WriteLine("Huy" + name);
        }
    }
    class Program{
        static void Main(string[] agrs){
            // Vukhi sungtruong = new Vukhi();
            // Vukhi sungluc = new Vukhi("sungluc");   
            // sungtruong.name = "sung truong ak";
            // sungtruong.thietlapdosatthuong(4);
            // sungtruong.Tancong();

            // Vukhi sungmay = new Vukhi("sung may",15);
            // sungmay.Tancong();
            // sungtruong.Tancong();
            // sungtruong.Satthuong = 12;

            Student student;
            
            student = new Student("sinh vien1");

            student = null;

        }
    }
}

