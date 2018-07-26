﻿using Mzl.UIModel.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mzl.UIModel.Customer.TravelReport
{
    public class TravelReportConsumeCountRequestViewModel : RequestBaseViewModel
    {
        /// <summary>
        /// 查询月份
        /// </summary>
        [Description("查询月份")]
        public int TheYear { get; set; }
        /// <summary>
        /// 查询类型
        /// </summary>
        [Description("查询类型")]
        public int sourceType { get; set; }
        /// <summary>
        /// 公司编号
        /// </summary>
        [Description("公司编号")]
        [Required]
        public string corpid { get; set; }
    }
}
