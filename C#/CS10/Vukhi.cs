using System; 

namespace CS10{
    class Vukhi{
        // du lieu 

        public string name = "ten vu khi";
        int dosatthuong = 0;

        // phuong thuc khoi tao
        public Vukhi(){
            Console.WriteLine("khoi tao");
            dosatthuong = 1;
        }

        public Vukhi( string abs){
            Console.WriteLine(abs);
        }

        // phuong thuc 
        public void thietlapdosatthuong(int dosatthuong){
            // this la tham chiieu 
            this.dosatthuong = dosatthuong;
        }

        public void Tancong(){

            Console.Write(name + ":\t");
            for (int i = 0; i < dosatthuong; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }

        public Vukhi(string name, int _dosatthuong){
            dosatthuong = _dosatthuong;
            this.name = name;
        }


        // thuoc tinh 
        public int Satthuong{
            // gan gia tri
            set{
                Console.WriteLine("SET");
                Console.WriteLine(value);
                dosatthuong = value;
            }

            // truy cap lay gia tri
            get{
                return dosatthuong;
            }
        }
    }
}