﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomometriOdev
{
    interface IUcgen
    {
        double TabanKenar { get; set; }
        double AlanHesapla();
        double CevreHesapla();
    }
}
