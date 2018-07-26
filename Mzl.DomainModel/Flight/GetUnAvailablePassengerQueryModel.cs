﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mzl.DomainModel.Flight
{
    public class GetUnAvailablePassengerQueryModel
    {
        /// <summary>
        /// Oa用户
        /// </summary>
        public string Oid { get; set; }
        /// <summary>
        /// 创建人名称
        /// </summary>
        public string CreateOName { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// 乘机人名称
        /// </summary>
        public string PassengerName { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public int? OrderId { get; set; }
        public DateTime? TackOffBeginTime { get; set; }
        public DateTime? TackOffEndTime { get; set; }
        public DateTime? OrderBeginTime { get; set; }
        public DateTime? OrderEndTime { get; set; }
        /// <summary>
        /// 当前显示多少条
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 第几页
        /// </summary>
        public int PageIndex { get; set; }
    }
}
