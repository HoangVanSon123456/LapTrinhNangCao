using System;
using System.Reflection.Metadata;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SoPhuc sp1 = new SoPhuc();
            sp1.Nhap();
            sp1.Xuat();
            SoPhuc sp2 = new SoPhuc();
            sp2.Nhap();
            sp2.Xuat();
            SoPhuc sp3 = new SoPhuc();
            sp3.Nhap();
            sp3.Xuat();
            SoPhuc sp4 = new SoPhuc();
            sp4 = sp1 - sp2;
            Console.WriteLine("hieu 2 so phuc");
            sp4.Xuat();
            SoPhuc sp5 = new SoPhuc();
            sp5 = sp1 + sp2;
            Console.WriteLine("tong 2 so phuc");
            sp5.Xuat();
            SoPhuc sp6 = new SoPhuc();
            sp6 = sp4 + sp2;
            Console.WriteLine("tich 2 so phuc");
            sp6.Xuat();
        }
    }
}
 