﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mzl.DomainModel.Customer.CorpAduit
{
    public class DoAduitOrderModel
    {
        /// <summary>
        /// 审批单Id
        /// </summary>
        [Description("审批单Id")]
        public int AduitOrderId { get; set; }
        /// <summary>
        /// 审批人Id
        /// </summary>
        [Description("审批人Id")]
        public int DealCid { get; set; }
        /// <summary>
        /// 审批员工Id TC端发起必填
        /// </summary>
        [Description("审批员工Id TC端发起必填")]
        public string DealOid { get; set; }
        /// <summary>
        /// 当前审批环节
        /// </summary>
        [Description("当前审批环节")]
        public int CurrentFlow { get; set; }
        /// <summary>
        /// 是否通过
        /// </summary>
        [Description("是否通过")]
        public bool IsAgree { get; set; }
        /// <summary>
        /// 审批填写的原因
        /// </summary>
        [Description("审批填写的原因")]
        public string AduitReason { get; set; }

        /// <summary>
        /// 操作来源
        /// </summary>
        [Description("操作来源")]
        public string DealSource { get; set; }
    }
}
