using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_quản_lý_cửa_hàng_xe_máy.model
{
    class luong
    {
        private string _maluong;
        private string _manv;
        private double _hesoluong;
        
        private double _tienluong;

        public luong() { }

        public luong(string maluong, string manv, double hesoluong, double tienluong)
        {
            _maluong = maluong;
            _manv = manv;
            _hesoluong = hesoluong;
            Tienluong = tienluong;
        }

        public string Maluong { get => _maluong; set => _maluong = value; }
        public string Manv { get => _manv; set => _manv = value; }
        public double Hesoluong { get => _hesoluong; set => _hesoluong = value; }
        public double Tienluong { get => _tienluong; set => _tienluong = value; }
    }  
}
