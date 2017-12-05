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
    public class PlanWithProcessSessionBusinessTest
    {
        protected PlanWithProcessSessionFactory ltr { get; set; }

        public PlanWithProcessSessionBusinessTest()
        {
            ltr = new PlanWithProcessSessionFactory();
        }
        [TestMethod]
        public void AddPlanWithProcessSession()
        {
            try
            {
                IPlanWithProcessSession planWithProcessSession = new PlanWithProcessSession()
                {
                    PlanWithProcessId = Guid.NewGuid(),
                    LeakDetailsId = Guid.Parse("C124835B-4B82-4CAB-A173-44601AC73012"),
                    ProcessStartDate = DateTime.Now,
                    OperatorName = "Dustin",
                    PlanWithProcessComments = "fdskjhfkjsdfhkjsdhfkjasf",
                };
                ltr.Create((PlanWithProcessSession)planWithProcessSession);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void UpdatePlanWithProcessSession()
        {
            try
            {
                IPlanWithProcessSession planWithProcessSession = new PlanWithProcessSession()
                {
                    PlanWithProcessId = Guid.Parse("12A2C784-6E90-45A6-8F20-27083FBDA06B"),
                    LeakDetailsId = Guid.Parse("C124835B-4B82-4CAB-A173-44601AC73012"),
                    ProcessStartDate = DateTime.Now,
                    OperatorName = "Dustin",
                    PlanWithProcessComments = "fdskjhfkjsdfhkjsdhfkjasf",
                };
                ltr.Update((PlanWithProcessSession)planWithProcessSession);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void GetPlanWithProcessSession()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}