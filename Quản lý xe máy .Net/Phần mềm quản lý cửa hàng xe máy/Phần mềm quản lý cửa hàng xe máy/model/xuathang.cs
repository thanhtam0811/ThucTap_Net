using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_quản_lý_cửa_hàng_xe_máy.model
{
    class xuathang
    {
        private string _maxuat;
        
        private string _mahang;
        private string _tennv;
        private DateTime _ngayxuat;
        private string _tenkh;
        private int _soluongxuat;
        private double _giaxuat;
        private double _thue;
        private double _thanhtien;

        public xuathang() { }

        public xuathang(string maxuat, string mahang, string tennv, DateTime ngayxuat, string tenkh, int soluongxuat, double giaxuat, double thue, double thanhtien)
        {
            Maxuat = maxuat;
            Mahang = mahang;
            Tennv = tennv;
            Ngayxuat = ngayxuat;
            Tenkh = tenkh;
            Soluongxuat = soluongxuat;
            Giaxuat = giaxuat;
            Thue = thue;
            Thanhtien = thanhtien;
        }

        public string Maxuat { get => _maxuat; set => _maxuat = value; }
        public string Mahang { get => _mahang; set => _mahang = value; }
        public string Tennv { get => _tennv; set => _tennv = value; }
        public DateTime Ngayxuat { get => _ngayxuat; set => _ngayxuat = value; }
        public string Tenkh { get => _tenkh; set => _tenkh = value; }
        public int Soluongxuat { get => _soluongxuat; set => _soluongxuat = value; }
        public double Giaxuat { get => _giaxuat; set => _giaxuat = value; }
        public double Thue { get => _thue; set => _thue = value; }
        public double Thanhtien { get => _thanhtien; set => _thanhtien = value; }
    }
}
