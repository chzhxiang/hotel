﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mzl.UIModel.Hotel.CTrip.City
{
    public class HotelProvinceViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        public List<HotelCityViewModel> Cities { get; set; }
    }
}
