using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLCuaHangGiaiKhat.Model;
using QLCuaHangGiaiKhat.Object;

namespace QLCuaHangGiaiKhat.Controller
{
    class KhachHangController
    {
        KhachHangModel nvMod = new KhachHangModel();
        public DataTable GetData()
        {
            return nvMod.GetData();
        }
        public bool AddData(KhachHangObj khObj)
        {
            return nvMod.AddData(khObj);
        }
        public bool UpdData(KhachHangObj khObj)
        {
            return nvMod.UpdData(khObj);
        }

        public bool UpdDiem(KhachHangObj khObj)
        {
            return nvMod.UpdDiem(khObj);
        }

        public bool DelData(string ma)
        {
            return nvMod.DelData(ma);
        }
    }
}
