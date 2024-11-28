using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_quản_lý_cửa_hàng_xe_máy.model
{
    class xemay
    {
        private string _mahang;
        private string _tenhang;
        private string _nhasanxuat;
        private string _mota;
        private int _soluong;
        private double _giaban;
        private string _donvitinh;
        
        private string _baohanh;

        public xemay() { }

        public xemay(string mahang, string tenhang, string nhasanxuat, string mota, int soluong, double giaban, string donvitinh, string baohanh)
        {
            Mahang = mahang;
            Tenhang = tenhang;
            Nhasanxuat = nhasanxuat;
            Mota = mota;
            Soluong = soluong;
            Giaban = giaban;
            Donvitinh = donvitinh;
            Baohanh = baohanh;
        }

        public string Mahang { get => _mahang; set => _mahang = value; }
        public string Tenhang { get => _tenhang; set => _tenhang = value; }
        public string Nhasanxuat { get => _nhasanxuat; set => _nhasanxuat = value; }
        public string Mota { get => _mota; set => _mota = value; }
        public int Soluong { get => _soluong; set => _soluong = value; }
        public double Giaban { get => _giaban; set => _giaban = value; }
        public string Donvitinh { get => _donvitinh; set => _donvitinh = value; }
        public string Baohanh { get => _baohanh; set => _baohanh = value; }
    }
    
    

}
