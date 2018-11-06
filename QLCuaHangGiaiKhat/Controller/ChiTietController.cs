using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLCuaHangGiaiKhat.Model;
using QLCuaHangGiaiKhat.Object;

namespace QLCuaHangGiaiKhat.Controller
{
    class ChiTietController
    {
        ChiTietModel ctMod = new ChiTietModel();
        public DataTable GetData(string ma)
        {
            return ctMod.GetData(ma);
        }
        public bool AddData(DataTable dt)
        {
            return ctMod.AddData(dt);
        }
        public bool DelData(string ma)
        {
            return ctMod.DelData(ma);
        }
    }
}
