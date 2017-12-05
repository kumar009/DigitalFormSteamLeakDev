using DigitalFormsSteamLeak.Business;
using DigitalFormsSteamLeak.Entity.IModels;
using DigitalFormsSteamLeak.Entity.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Business.Test
{
    [TestClass]
    public class WorkOrderStatusSessionBusinessTest
    {
        protected WorkOrderStatusSessionFactory ltr { get; set; }

        public WorkOrderStatusSessionBusinessTest()
        {
            ltr = new WorkOrderStatusSessionFactory();
        }

        [TestMethod]
        public void AddWorkOrderStatusSession()
        {
            try
            {
                IWorkOrderStatusSession workOrderStatusSession = new WorkOrderStatusSession()
                {
                    WorkOrderStatusId = Guid.NewGuid(),
                    LeakDetailsId = Guid.Parse("C124835B-4B82-4CAB-A173-44601AC73012"),
                    WorkDoneBy = "scaffold",
                    WorkOrderStatus = "is under process",
                    WorkOrderStatusComments = "sdkjksdjfklsjflksa",
                    WorkOrderCompletedDate = DateTime.Now,
                };
                ltr.Create((WorkOrderStatusSession)workOrderStatusSession);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void UpdateWorkOrderStatusSession()
        {
            try
            {
                IWorkOrderStatusSession workOrderStatusSession = new WorkOrderStatusSession()
                {
                    WorkOrderStatusId = Guid.Parse("C696FC81-40B8-4875-A7D0-90486D3199D4"),
                    LeakDetailsId = Guid.Parse("C124835B-4B82-4CAB-A173-44601AC73012"),
                    WorkDoneBy = "scaffold",
                    WorkOrderStatus = "is under process",
                    WorkOrderStatusComments = "sdkjksdjfklsjflksa",
                    WorkOrderCompletedDate = DateTime.Now,
                };
                ltr.Update((WorkOrderStatusSession)workOrderStatusSession);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void GetWorkOrderStatusSession()
        {
            try
            {
                var list = ltr.GetAll().ToList();
                Assert.IsNotNull(list);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}