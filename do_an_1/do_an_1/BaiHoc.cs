﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace do_an_1
{
    public class BaiHoc
    {
        [PrimaryKey, AutoIncrement]
        public int MaBH { get; set; }
        public string TenBH { get; set; }
        public string Hinh { get; set; }
        public int MaChang { get; set; }
        public string ThanhTich { get; set; }
       /* public int MaND { get; set; }
        
       public BaiHoc(int mabh, string tenbh, string hinh, int machang, int mand)
        {
            MaBH = mabh;
            TenBH = tenbh;
            Hinh = hinh;
            MaChang = machang;
        }*/
    }

}
