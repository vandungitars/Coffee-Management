﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLCuaHangGiaiKhat.Model;
using QLCuaHangGiaiKhat.Object;
namespace QLCuaHangGiaiKhat.Controller
{
    class HoaDonController
    {
        HoaDonModel hdMod = new HoaDonModel();
        public DataTable GetData()
        {
            return hdMod.GetData();
        }
        public bool AddData(HoaDonObj hdObj)
        {
            return hdMod.AddData(hdObj);
        }
        public bool DelData(string ma)
        {
            return hdMod.DelData(ma);
        }
    }
}
