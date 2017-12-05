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
    public class PortalInsulationRemoveSessionBusinessTest
    {
        protected PortalInsulationRemoveSessionFactory ltr { get; set; }

        public PortalInsulationRemoveSessionBusinessTest()
        {
            ltr = new PortalInsulationRemoveSessionFactory();
        }

        [TestMethod]
        public void AddPortalInsulationRemoveSession()
        {
            try
            {
                IPortalInsulationRemoveSession portalInsulationRemoveSession = new PortalInsulationRemoveSession()
                {
                    RemoveInsulationId = Guid.NewGuid(),
                    LeakDetailsId = Guid.Parse("9697B7C4-CD2E-4243-9642-D3FA01A2B5E1"),
                    RemovingType = "asbestos",
                    Temperature = 2.2M,
                    PipeDiameter = 2.2M,
                    LinearFt = 2,
                    Fittings = "90ts",
                    AdditionalComments = "portalrempve comments",
                    RequestCreatedDate = DateTime.Now,
                    RequestStartDate = DateTime.Now,
                    RequestEndDate = DateTime.Now,
                    RequestComments = "djfsdjfjhsdj",

                };
                ltr.Create((PortalInsulationRemoveSession)portalInsulationRemoveSession);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void UpdatePortalInsulationRemoveSession()
        {
            try
            {
                IPortalInsulationRemoveSession portalInsulationRemoveSession = new PortalInsulationRemoveSession()
                {
                    RemoveInsulationId = Guid.Parse("3C443900-8CC7-444D-BCD0-A742E58FC770"),
                    LeakDetailsId = Guid.Parse("C124835B-4B82-4CAB-A173-44601AC73012"),
                    RemovingType = "asbestos",
                    Temperature = 2.2M,
                    PipeDiameter = 2.2M,
                    LinearFt = 2,
                    Fittings = "90ts",
                    AdditionalComments = "portalrempve comments",
                    RequestCreatedDate = DateTime.Now,
                    RequestStartDate = DateTime.Now,
                    RequestEndDate = DateTime.Now,
                    RequestComments = "djfsdjfjhsdj",

                };
                ltr.Update((PortalInsulationRemoveSession)portalInsulationRemoveSession);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void GetPortalInsulationRemoveSession()
        {
            try
            {
                var list = ltr.GetAll().ToList();
                Assert.IsNotNull(list);

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}