﻿using Mzl.Application.Train.Order.Domain;
using Mzl.BLL.Train.Server.Factory;
using Mzl.DomainModel.Train.Server;
using Mzl.IApplication.Train.Order.Domain;
using Mzl.IApplication.Train.Order.Factory;
using Mzl.IBLL.Train.Server.BLL;
using Mzl.IBLL.Train.Server.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mzl.Application.Train.Order.Factory
{
   public class TrainInfoFactory:IServerDomainFactory
    {
        public IServerDomain CreateDomainObj()
        {
            //业务(占位)单元工厂，创建业务单元，通过构造注入到Domain中
            ITrainInfoServerBLLFactory factory = new TrainInfoServerBLLFactory();
            ITrainInfoServerBLL<List<TraTrainInfoResponseDateDetailModel>> trainInfoServer = factory.CreateSampleBllObj();
            IServerDomain domain = new ServerDomain(trainInfoServer);
            return domain;
        }
    }
}
