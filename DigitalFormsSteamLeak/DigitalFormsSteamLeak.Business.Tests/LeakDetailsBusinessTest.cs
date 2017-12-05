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
    public class LeakDetailsBusinessTest
    {
        protected LeakDetailsFactory ltr { get; set; }
        public LeakDetailsBusinessTest()
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
                leakDetails.UserId = Guid.Parse("47EAD6D9-C95F-4592-B5C4-229E19D13E7A");
                leakDetails.LeakTypeId = Guid.Parse("91C04BD6-9794-46F9-9806-C9CDE47595F1");
                leakDetails.UnitId = Guid.Parse("6EFD9490-7CFA-4EB1-8C5A-28B0A98936F8");
                leakDetails.LeakNumber = 2;
                leakDetails.ScoopedDate = DateTime.Now;
                leakDetails.NotificationNumber = 1233;
                leakDetails.DateNotificationReceived = DateTime.Now;
                leakDetails.WorkOrderNumber = 1234;
                leakDetails.DateWorkOrderReceived = DateTime.Now;
                leakDetails.WorkOrderDescription = "the work order is received";
                leakDetails.SSTDescription = "The Sst description is received";
                leakDetails.IdentifiedBy = "steam";
                leakDetails.DecibelReading = 2.2f;
                leakDetails.HeightFromGrade = 2.2f;
                leakDetails.HeightFromLeak = 2.2f;
                leakDetails.ExistingHearingProtection = "single";
                leakDetails.Populate = "y";
                leakDetails.PlumeSize = 100.0f;
                leakDetails.Temperature = 100.0f;
                leakDetails.OrificeSize = 100.0f;
                leakDetails.LOCReading = 100;
                leakDetails.LOCRate = 100;
                leakDetails.IsPlanWithProcessReqired = "y";
                leakDetails.IsFEWARequired = "y";
                //leakDetails.IsAttach2Required = "y";
                leakDetails.IsMOCRequired = "y";
                leakDetails.IsRemoveInsulationRequired = "y";
                leakDetails.IsReinstallInsulationRequired = "y";
                leakDetails.IsReScopeRequired = "y";
                leakDetails.JobPackStatus = "y";
                leakDetails.LeakStatus = "y";
                leakDetails.LeakComments = "y";

                ltr.Create((LeakDetails)leakDetails);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void UpdateLeakDetails()
        {
            try
            {
                ILeakDetails leakDetails = new LeakDetails();
                leakDetails.LeakDetailsId = Guid.Parse("3AED254F-9ADC-4BE4-BFCD-659966C588A1");
                leakDetails.UserId = Guid.Parse("47EAD6D9-C95F-4592-B5C4-229E19D13E7A");
                leakDetails.LeakTypeId = Guid.Parse("91C04BD6-9794-46F9-9806-C9CDE47595F1");
                leakDetails.UnitId = Guid.Parse("6EFD9490-7CFA-4EB1-8C5A-28B0A98936F8");//refer unit table to add new ref
                leakDetails.LeakNumber = 2;
                leakDetails.ScoopedDate = DateTime.Now;
                leakDetails.NotificationNumber = 1233;
                leakDetails.DateNotificationReceived = DateTime.Now;
                leakDetails.WorkOrderNumber = 1234;
                leakDetails.DateWorkOrderReceived = DateTime.Now;
                leakDetails.WorkOrderDescription = "the work order is received";
                leakDetails.SSTDescription = "The Sst description is received";
                leakDetails.IdentifiedBy = "steam";
                leakDetails.DecibelReading = 0f;
                leakDetails.HeightFromGrade = 2.2f;
                leakDetails.HeightFromLeak = 2.2f;
                leakDetails.ExistingHearingProtection = "single";
                leakDetails.Populate = "y";
                leakDetails.PlumeSize = 100.0f;
                leakDetails.Temperature = 100.0f;
                leakDetails.OrificeSize = 100.0f;
                leakDetails.LOCReading = 100;
                leakDetails.LOCRate = 100;
                leakDetails.IsPlanWithProcessReqired = "y";
                leakDetails.IsFEWARequired = "y";
                //leakDetails.IsAttach2Required = "y";
                leakDetails.IsMOCRequired = "y";
                leakDetails.IsRemoveInsulationRequired = "y";
                leakDetails.IsReinstallInsulationRequired = "y";
                leakDetails.IsReScopeRequired = "y";
                leakDetails.JobPackStatus = "y";
                leakDetails.LeakStatus = "y";
                leakDetails.LeakComments = "y";

                ltr.Update((LeakDetails)leakDetails);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void GetLeakDetails()
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
