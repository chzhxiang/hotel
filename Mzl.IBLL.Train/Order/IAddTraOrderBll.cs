﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mzl.DomainModel.Train.Order;

namespace Mzl.IBLL.Train.Order
{
    public interface IAddTraOrderBll
    {
        int AddTraOrder(TraAddOrderModel traAddOrder);
    }
}
