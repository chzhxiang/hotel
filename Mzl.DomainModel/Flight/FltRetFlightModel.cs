﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mzl.DomainModel.Flight
{
    public class FltRetFlightModel : FltFlightModel
    {
        public List<FltPassengerModel> PassengerList { get; set; }
    }
}
