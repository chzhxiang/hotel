﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mzl.DomainModel.Customer.Base;

namespace Mzl.DomainModel.Flight
{
    public class GetRetApplyQueryModel
    {
        public int? Cid { get; set; }
        public int OrderId { get; set; }
        public SearchCityAportModel AportInfo { get; set; }
        public CustomerModel Customer { get; set; }
        public List<int> CidList { get; set; }
    }
}
