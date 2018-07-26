﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mzl.DomainModel.Train.Server
{
  public  class TraRequestChangeResponseModel:BaseOutputModel
    {
        /// <summary>
        /// 请求特征值[异步改签时的同步输出和异步回调有值]
        /// </summary>  
        [Description("请求特征值[异步改签时的同步输出和异步回调有值]")]
        public string reqtoken { get; set; }

        /// <summary>
        /// 交易单号
        /// </summary>  
        [Description("交易单号]")]
        public string transactionid { get; set; }

        /// <summary>
        /// 使用方订单号
        /// </summary>  
        [Description("使用方订单号")]
        public string orderid { get; set; }

        /// <summary>
        /// 在预订失败的情况下，给出帮助提示信息，可以直接展示给客户看。
        /// </summary>  
        [Description("在预订失败的情况下，给出帮助提示信息，可以直接展示给客户看。")]
        public string help_info { get; set; }
    















    }
}
