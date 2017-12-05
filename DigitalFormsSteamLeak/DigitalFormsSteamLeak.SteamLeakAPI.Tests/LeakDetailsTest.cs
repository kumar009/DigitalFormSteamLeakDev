using DigitalFormsSteamLeak.Business;
using DigitalFormsSteamLeak.Entity.IModels;
using DigitalFormsSteamLeak.Entity.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.SteamLeaksAPI.UnitTests
{
    [TestClass]
    public class LeakDetailsTest
    {
        protected LeakDetailsFactory ltr { get; set; }
        public LeakDetailsTest()
        {
            ltr = new LeakDetailsFactory();
        }

        [TestMethod]
        public void AddLeakDetails()
        {
            try
            {
                ILeakDetails leakDetails = new LeakDetails();
                leakDetails.LeakDetailsId = Guid.NewGuid();
                leakDetails.UserId = Guid.Parse("57BB12E7-85F1-4612-98BA-215028590D53");
                leakDetails.LeakTypeId = Guid.Parse("B9219816-7D18-4534-A29A-50684D47E449");
                leakDetails.UnitId = Guid.Parse("D73554EA-A8A6-4779-8C91-051024F488F2");
                leakDetails.LeakNumber = 2;
                leakDetails.ScoopedDate = DateTime.Now;
                leakDetails.NotificationNumber = 123323;
                leakDetails.DateNotificationReceived = DateTime.Parse("10/10/2017");
                leakDetails.WorkOrderNumber = 1234;
                leakDetails.DateWorkOrderReceived = DateTime.Now;
                leakDetails.WorkOrderDescription = "the work order is received";
                leakDetails.SSTDescription = "The Sst description is received";
                leakDetails.IdentifiedBy = "steam";
                leakDetails.DecibelReading = 2.2f;
                leakDetails.HeightFromGrade = 2.2f;
                leakDetails.HeightFromLeak = 2.2f;
                leakDetails.ExistingHearingProtection = "single";
                leakDetails.Populate ="Y";
                leakDetails.PlumeSize =100.0f;
                leakDetails.Temperature =100.0f;
                leakDetails.OrificeSize =100.0f;
                leakDetails.LOCReading =100.0f;
                leakDetails.LOCRate = 100.0f;
                leakDetails.IsPlanWithProcessReqired ="Y";
                leakDetails.IsFEWARequired ="Y";
                //leakDetails.IsAttach2Required = "Y";
                leakDetails.IsMOCRequired ="Y";
                leakDetails.IsRemoveInsulationRequired ="Y";
                leakDetails.IsReinstallInsulationRequired ="Y";
                leakDetails.IsReScopeRequired ="Y";
                leakDetails.JobPackStatus ="NEW";
                leakDetails.LeakStatus ="NEW";
                leakDetails.LeakComments ="CREATED";

                ltr.Create((LeakDetails)leakDetails);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}