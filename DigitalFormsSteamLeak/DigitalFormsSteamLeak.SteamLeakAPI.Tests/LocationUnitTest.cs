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
    public class LocationUnitTest
    {
        protected LocationUnitFactory ltr { get; set; }
        public LocationUnitTest()
        {
            ltr = new LocationUnitFactory();
        }
        [TestMethod]
        public void AddLocationUnit()
        {
            try
            {
                ILocationUnit locationUnit = new LocationUnit();
                locationUnit.UnitId = Guid.NewGuid();
                locationUnit.UnitName = "HCP2";
                locationUnit.BusinessLocationId = Guid.Parse("9966B4BA-BE61-49AA-8010-82F55590961C");
                ltr.Create((LocationUnit)locationUnit);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void UpdateLocationUnit()
        {
            try
            {
                ILocationUnit locationUnit = new LocationUnit();
                locationUnit.UnitId = Guid.Parse("E8287DE6-39E5-4170-A4EA-D41BA50987AC");
                locationUnit.UnitName = "HCN2";
                locationUnit.BusinessLocationId = Guid.Parse("9966B4BA-BE61-49AA-8010-82F55590961C");
                ltr.Update((LocationUnit)locationUnit);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void GetLocationUnit()
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