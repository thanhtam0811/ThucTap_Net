using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_quản_lý_cửa_hàng_xe_máy.model
{
    class nhaphang
    {
        private string _manhap;
        private string _manv;
        private string _mahang;
        private string _mancc;
        private DateTime _ngaynhap;
        private int _soluongnhap;
        private double _gianhap;
        private double _thue;
        private double _thanhtien;
        
        
        public nhaphang() { }

        public nhaphang(string manhap, string manv, string mahang, string mancc, DateTime ngaynhap, int soluongnhap, double gianhap, double thue, double thanhtien)
        {
            Manhap = manhap;
            Manv = manv;
            Mahang = mahang;
            Mancc = mancc;
            Ngaynhap = ngaynhap;
            Soluongnhap = soluongnhap;
            Gianhap = gianhap;
            Thue = thue;
            Thanhtien = thanhtien;
        }

        public string Manhap { get => _manhap; set => _manhap = value; }
        public string Manv { get => _manv; set => _manv = value; }
        public string Mahang { get => _mahang; set => _mahang = value; }
        public string Mancc { get => _mancc; set => _mancc = value; }
        public DateTime Ngaynhap { get => _ngaynhap; set => _ngaynhap = value; }
        public int Soluongnhap { get => _soluongnhap; set => _soluongnhap = value; }
        public double Gianhap { get => _gianhap; set => _gianhap = value; }
        public double Thue { get => _thue; set => _thue = value; }
        public double Thanhtien { get => _thanhtien; set => _thanhtien = value; }
    }
}
