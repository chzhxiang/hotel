﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mzl.EntityModel.Customer.Corporation.CorpPolicy
{
    [Table("P_CorpPolicyConfig_Project")]
    public class CorpPolicyConfigProjectEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        [Description("Id")]
        public int Id { get; set; }
        /// <summary>
        /// 项目成本中心Id
        /// </summary>
        [Description("项目成本中心Id")]
        public int ProjectId { get; set; }
        /// <summary>
        /// 政策Id
        /// </summary>
        [Description("政策Id")]
        public int PolicyId { get; set; }
    }
}
