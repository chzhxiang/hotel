﻿using Mzl.DomainModel.Flight;
using Mzl.Framework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mzl.IBLL.Flight.DomesticRetMod
{
    public interface IConfirmModAuditPriceServiceBll : IBaseServiceBll
    {
        ConfirmRetModAuditPriceResultModel ConfirmModAuditPrice(ConfirmRetModAuditPriceModel query);
    }
}