﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mzl.DomainModel.Customer.Base;
using Mzl.DomainModel.Customer.CorpPolicy;
using Mzl.DomainModel.Customer.MatchCorpPolicyAndAduit;

namespace Mzl.BLL.Customer.MatchCorpPolicyAndAduit
{
    /// <summary>
    /// 相同部门
    /// </summary>
    public class SameDepartmentBll: BaseMatchBll
    {
        public SameDepartmentBll(List<int> cidList, List<CustomerModel> customerList, int isAllowUserInsurance)
            : base(cidList, customerList, isAllowUserInsurance)
        {
        }

        public override MatchCorpPolicyAndAduitResultModel DoMatch(IMatchVisitor macthVisitor)
        {
            return macthVisitor.DoMatch(this);
        }
    }
}
