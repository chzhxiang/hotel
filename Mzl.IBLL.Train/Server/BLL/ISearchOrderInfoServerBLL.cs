﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mzl.IBLL.Train.Server.BLL
{
public    interface ISearchOrderInfoServerBLL<out T> : IBaseServerBLL where T : class
    {
      

        T DoOrderInfo();
    }
}