using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class SinhVien
    {
        public string masv, tensv, tenlop, ngaysinh;
        public string mssv
        {
            get { return masv; }
            set { masv = value; }
        }
        public string hoten
        {
            get { return tensv; }
            set { tensv = value; }
        }
        public string lop
        {
            get { return tenlop; }
            set { tenlop = value; }
        }
        public string namsinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public SinhVien() 
        {
            masv = "2001216275";
            tensv = "Pham Diep Quang Tu";
            tenlop = "12DHTH15";
            ngaysinh = "14/08/2002";
            
        }
        public void diChoi()
        {
            Console.WriteLine(tensv + " di hoc cong nghe NET");
        }
        public void diHoc() 
        {
            Console.WriteLine(tensv + " hoc lap trinh web");
        }
    }
}
