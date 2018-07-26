﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mzl.UIModel.Search
{
  public  class TraOrderConfirmResponseViewModel
    {
        /// <summary>
        /// 使用方订单号
        /// </summary>  
        [Description("使用方订单号")]
        public string OrderID { get; set; }

        /// <summary>
        /// 交易单号
        /// </summary>  
        [Description("交易单号")]
        public string OrderNumber { get; set; }


    }
}
