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
    public class LeakTypeBusinessTest
    {
        protected LeakTypeFactory ltr { get; set; }
        public LeakTypeBusinessTest()
        {
            ltr = new LeakTypeFactory();
        }

        [TestMethod]
        public void AddLeakType()
        {
            try
            {
                ILeakType leaktype = new LeakType();
                leaktype.LeakTypeId = Guid.NewGuid();
                leaktype.LeakTypeName = "LP CONDENSATE3";

                ltr.Create(leaktype);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void UpdateLeakType()
        {
            try
            {
                ILeakType leakType = new LeakType();
                leakType.LeakTypeId = Guid.Parse("1A61AA3A-F450-4CC7-A3B3-F31F6DD234CA");
                leakType.LeakTypeName = "HP Leak";

                ltr.Update((LeakType)leakType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void GetLeakType()
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