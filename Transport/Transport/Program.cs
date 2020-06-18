using System;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loai Phuong tie ban muon chon: ");
            Console.WriteLine("1 la oto");
            Console.WriteLine("2 la tau thuy");
            Console.WriteLine("3 la may bay");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    phuongtien oto = new oTo();
                    oto.diChuyen();
                    break;
                case 2:
                    phuongtien tau = new Tau();
                    tau.diChuyen();
                    break;
                case 3:
                    phuongtien maybay = new MayBay();
                    maybay.diChuyen();
                    break;
                default:
                    Console.WriteLine("chon ko hop le");
                    break;
            }
            Console.WriteLine("\nfreetuts chuc ban hoc tot !!!");
            Console.ReadKey();
        }
    }
}
