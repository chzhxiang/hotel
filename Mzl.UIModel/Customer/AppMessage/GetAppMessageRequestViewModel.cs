﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mzl.UIModel.Base;

namespace Mzl.UIModel.Customer.AppMessage
{
    public class GetAppMessageRequestViewModel : RequestBaseViewModel
    {
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
