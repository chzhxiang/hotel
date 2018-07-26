﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mzl.DomainModel.Flight;
using Mzl.Framework.Base;

namespace Mzl.IBLL.Flight.DomesticRetMod
{
    public interface IQueryFlightRetApplyListServiceBll : IBaseServiceBll
    {
        QueryFlightRetApplyListModel QueryFlightRetApplyList(QueryFlightRetApplyListDataQueryModel query);
    }
}
