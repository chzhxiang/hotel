﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mzl.UIModel.Base;

namespace Mzl.UIModel.Flight
{
    public class CancelFltOrderRequestViewModel : RequestBaseViewModel
    {
        public int OrderId { get; set; }
    }
}
