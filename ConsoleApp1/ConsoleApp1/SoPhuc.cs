using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SoPhuc
    {
        private
            float pt;
            float pa;

        public
        SoPhuc()
        { }
        public SoPhuc(float t, float a)
        {
            pt = t;
            pa = a;
        }
        public void Nhap()
        {
            Console.Write("Nhap Phan Thuc: ");
            pt = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap Phan Ao: ");
            pa = Convert.ToInt16(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("{0} + {1}*i", pt, pa);
        }
        public static SoPhuc operator +(SoPhuc a ,SoPhuc b)
        {
            SoPhuc soPhuc = new SoPhuc();
            soPhuc.pt = a.pt + b.pt;
            soPhuc.pa = a.pa + b.pa;
            return soPhuc;
        }
        public static SoPhuc operator -(SoPhuc a, SoPhuc b)
        {
            SoPhuc soPhuc = new SoPhuc();
            soPhuc.pt = a.pt - b.pt;
            soPhuc.pa = a.pa - b.pa;
            return soPhuc;
        }
        public static SoPhuc operator *(SoPhuc a, SoPhuc b)
        {
            SoPhuc soPhuc = new SoPhuc();
            soPhuc.pt = a.pt*b.pt - a.pa*b.pa;
            soPhuc.pa = a.pt*b.pa + a.pa*b.pt;
            return soPhuc;
        }

    }
}