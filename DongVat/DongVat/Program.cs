using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap con vat ban muon chon: ");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("Bạn đã chọn mèo");
                    DongVat meo = new Cat();
                    Console.WriteLine("Tiếng mèo kêu: ");
                    meo.speak();
                    Console.WriteLine("Di chuyển mèo: ");
                    meo.move();
                    Console.WriteLine("Mèo ăn: ");
                    meo.eat();
                    break;
                case 2:
                    DongVat chim = new Bird();
                    Console.WriteLine("Bạn đã chọn chim:");
                    Console.WriteLine("Tiếng chm kêu: ");
                    chim.speak();
                    Console.WriteLine("Di chuyển chim: ");
                    chim.move();
                    Console.WriteLine("chim ăn: ");
                    chim.eat();
                    break;
                default:
                    Console.WriteLine(" nhap khong hop le");
                    break;
            }
            }
    }
}
