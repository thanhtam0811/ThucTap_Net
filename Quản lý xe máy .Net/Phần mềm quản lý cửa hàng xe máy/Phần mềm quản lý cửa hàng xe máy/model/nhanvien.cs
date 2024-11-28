using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_quản_lý_cửa_hàng_xe_máy.model
{
    class nhanvien
    {
        private string _manv;
        private string _tennv;
        private string _gioitinh;
        private DateTime _namsinh;
        private string _diachi;
        private string _sodienthoai;
        private string _email;
        private string _chucvu;
        private double _luongcoban;
        

        public nhanvien() { }

        public nhanvien(double luongcoban)
        {
            _luongcoban = luongcoban;
        }

        public nhanvien(string manv, string tennv, string gioitinh, DateTime namsinh, string diachi, string sodienthoai, string email, string chucvu)
        {
            _manv = manv;
            _tennv = tennv;
            _gioitinh = gioitinh;
            _namsinh = namsinh;
            _diachi = diachi;
            _sodienthoai = sodienthoai;
            _email = email;
            _chucvu = chucvu;
        }

        public string Manv { get => _manv; set => _manv = value; }
        public string tennv { get => _tennv; set => _tennv = value; }
        public string Gioitinh { get => _gioitinh; set => _gioitinh = value; }
        public DateTime Namsinh { get => _namsinh; set => _namsinh = value; }
        public string Diachi { get => _diachi; set => _diachi = value; }
        public string Sodienthoai { get => _sodienthoai; set => _sodienthoai = value; }
        public string Email { get => _email; set => _email = value; }
        public string Chucvu { get => _chucvu; set => _chucvu = value; }
        public double Luongcoban { get => _luongcoban; set => _luongcoban = value; }
    }
}
