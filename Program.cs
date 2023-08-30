using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Buoi2
{
    class Program : SinhVien
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            sv.diChoi();
            sv.diHoc();
            sv.diAn();
            Console.ReadKey();
        }
    }
}