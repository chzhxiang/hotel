﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mzl.DomainModel.Flight
{
    public class SearchCityModel : CityModel
    {
        public List<SearchAirportModel> AirportList { get; set; }
    }
}
