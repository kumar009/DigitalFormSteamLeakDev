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
    public class PortalInsulatioReinstallSessionBusinessTest
    {
        protected PortalInsulationReInstallSessionFactory ltr { get; set; }

        public PortalInsulatioReinstallSessionBusinessTest()
        {
            ltr = new PortalInsulationReInstallSessionFactory();
        }

        [TestMethod]
        public void AddPortalInsulationReInstallSession()
        {
            try
            {
                IPortalInsulationReInstallSession portalInsulatioReInstallSession = new PortalInsulationReInstallSession()
                {
                    ReinstallInsulationId = Guid.NewGuid(),
                    LeakDetailsId = Guid.Parse("C124835B-4B82-4CAB-A173-44601AC73012"),
                    ReinstallInsulationType = "copper",
                    RequestStartDate = DateTime.Now,
                    RequestCreatedDate = DateTime.Now,
                    RequestEndDate = DateTime.Now,
                    RequestComments = "No comments needed",
                };
                ltr.Create((PortalInsulationReInstallSession)portalInsulatioReInstallSession);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void UpdatePortalInsulationReInstallSession()
        {
            try
            {
                IPortalInsulationReInstallSession portalInsulatioReInstallSession = new PortalInsulationReInstallSession()
                {
                    ReinstallInsulationId = Guid.Parse("CEA1CDE1-8D2F-4C07-8F39-933623DAAF4E"),
                    LeakDetailsId = Guid.Parse("C124835B-4B82-4CAB-A173-44601AC73012"),
                    ReinstallInsulationType = "asbestos",
                    RequestStartDate = DateTime.Now,
                    RequestCreatedDate = DateTime.Now,
                    RequestEndDate = DateTime.Now,
                    RequestComments = "sdfdsfsdfs",
                };
                ltr.Update((PortalInsulationReInstallSession)portalInsulatioReInstallSession);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void GetPortalINsulationReinstallSession()
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
