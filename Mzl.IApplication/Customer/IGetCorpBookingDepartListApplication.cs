﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mzl.Framework.Base;
using Mzl.UIModel.Customer.Customer;

namespace Mzl.IApplication.Customer
{
    public interface IGetCorpBookingDepartListApplication: IBaseApplication
    {
        GetCorpBookingDepartListResponseViewModel GetCorpBookingDepartList(GetCorpBookingDepartListRequestViewModel request);
    }
}
