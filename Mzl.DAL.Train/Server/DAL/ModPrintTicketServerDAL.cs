﻿using Mzl.IDAL.Train.Server.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mzl.Common.DBHelper;
using Mzl.EntityModel.Train.Server;
using Mzl.EntityModel.EFContext;

namespace Mzl.DAL.Train.Server.DAL
{
    class ModPrintTicketServerDAL : IModPrintTicketServerDAL
    {
        public TraModPrintTicketCallBackLogEntity Query(int id)
        {
            using (BrightourDbContext db = new BrightourDbContext())
            {
                var result = db.TraModPrintTicketCallBackLog.Where(n => n.LogId == id).ToList();
                return result.First();
            }
        }

        public int Insert(TraModPrintTicketCallBackLogEntity t)
        {
            using (BrightourDbContext db = new BrightourDbContext())
            {
                var log = db.TraModPrintTicketCallBackLog.Add(t);
                db.SaveChanges();
                return log.LogId;
            }
        }

        public int Update(TraModPrintTicketCallBackLogEntity t, string[] properties = null)
        {
            using (BrightourDbContext db = new BrightourDbContext())
            {
                return db.Update(t, properties);
            }
        }

        public int Delete(TraModPrintTicketCallBackLogEntity t)
        {
            using (BrightourDbContext db = new BrightourDbContext())
            {
                db.TraModPrintTicketCallBackLog.Attach(t);
                db.TraModPrintTicketCallBackLog.Remove(t);
                int i = db.SaveChanges();
                //string sql = $"delete from dbo.Tra_HoldSeatCallBackLog where logid={t.LogId}";
                //db.Database.ExecuteSqlCommand(sql);
                if (i > 0)
                    return 0;
                return -1;
            }
        }
    }
}
