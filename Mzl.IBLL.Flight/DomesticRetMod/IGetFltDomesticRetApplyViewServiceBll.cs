﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mzl.DomainModel.Flight;

namespace Mzl.IBLL.Flight.DomesticRetMod
{
    public interface IGetFltDomesticRetApplyViewServiceBll
    {
        GetRetApplyModel GetRetApply(GetRetApplyQueryModel query);
    }
}
