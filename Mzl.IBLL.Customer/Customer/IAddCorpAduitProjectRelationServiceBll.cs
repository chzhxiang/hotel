﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mzl.DomainModel.Customer.CorpAduit;
using Mzl.Framework.Base;

namespace Mzl.IBLL.Customer.Customer
{
    public interface IAddCorpAduitProjectRelationServiceBll : IBaseServiceBll
    {
        bool AddCorpAduitProjectRelation(CorpAduitConfigProjectModel model);
    }
}