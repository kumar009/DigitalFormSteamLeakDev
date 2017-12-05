using DigitalFormsSteamLeak.Business;
using DigitalFormsSteamLeak.Entity.IModels;
using DigitalFormsSteamLeak.Entity.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.Business.UnitTest
{
    [TestClass]
    public class LocationBusinessBusinessTest
    {
        protected LocationBusinessFactory ltr { get; set; }
        public LocationBusinessBusinessTest()
        {
            ltr = new LocationBusinessFactory();
        }
        [TestMethod]
        public void AddLocationBusiness()
        {
            try
            {
                ILocationBusiness locationbusiness = new LocationBusiness();
                locationbusiness.BusinessLocationId = Guid.NewGuid();
                locationbusiness.BusinessName = "Cat Cracker2";
                locationbusiness.DepartmentId = Guid.Parse("9EBA6D35-66D7-4905-8D2D-34F772D03733");
                ltr.Create((LocationBusiness)locationbusiness);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        [TestMethod]
        public void UpdateLocationBusiness()
        {
            try
            {
                ILocationBusiness locationbusiness = new LocationBusiness();
                locationbusiness.BusinessLocationId = Guid.Parse("237E51C1-E759-4C5F-82E2-7233F833D241");
                locationbusiness.BusinessName = "Cat Cracker";
                locationbusiness.DepartmentId = Guid.Parse("6EFD9490-7CFA-4EB1-8C5A-28B0A98936F8");
                ltr.Update((LocationBusiness)locationbusiness);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void GetBusiness()
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