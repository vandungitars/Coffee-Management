using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLCuaHangGiaiKhat.Model;
using QLCuaHangGiaiKhat.Object;

namespace QLCuaHangGiaiKhat.Controller
{
    class NhanVienController
    {
        NhanVienModel nvMod = new NhanVienModel();
        public DataTable GetData()
        {
            return nvMod.GetData();
        }
        public bool AddData(NhanVienObj nvObj)
        {
            return nvMod.AddData(nvObj);
        }
        public bool UpdData(NhanVienObj nvObj)
        {
            return nvMod.UpdData(nvObj);
        }
        public bool UpdMK(NhanVienObj nvObj)
        {
            return nvMod.UpdMK(nvObj);
        }
        public bool DelData(string ma)
        {
            return nvMod.DelData(ma);
        }
    }
}
