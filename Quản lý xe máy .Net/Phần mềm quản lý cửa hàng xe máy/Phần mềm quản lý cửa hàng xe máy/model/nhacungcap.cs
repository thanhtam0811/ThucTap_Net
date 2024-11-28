using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_quản_lý_cửa_hàng_xe_máy.model
{
    class nhacungcap
    {
        private string _mancc;
        private string _tenncc;
        private string _diachincc;
        private string _sodienthoaincc;
        private string _emailncc;

        public nhacungcap(string mancc, string tenncc, string diachincc, string sodienthoaincc, string emailncc)
        {
            Mancc = mancc;
            Tenncc = tenncc;
            Diachincc = diachincc;
            Sodienthoaincc = sodienthoaincc;
            Emailncc = emailncc;
        }

        public string Mancc { get => _mancc; set => _mancc = value; }
        public string Tenncc { get => _tenncc; set => _tenncc = value; }
        public string Diachincc { get => _diachincc; set => _diachincc = value; }
        public string Sodienthoaincc { get => _sodienthoaincc; set => _sodienthoaincc = value; }
        public string Emailncc { get => _emailncc; set => _emailncc = value; }

        public nhacungcap() { } 


    }
}
