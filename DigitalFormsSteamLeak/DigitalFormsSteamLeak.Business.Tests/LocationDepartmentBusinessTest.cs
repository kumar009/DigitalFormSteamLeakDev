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
    public class LocationDepartmentBusinessTest
    {
        protected LocationDepartmentFactory ltr { get; set; }
        public LocationDepartmentBusinessTest()
        {
            ltr = new LocationDepartmentFactory();
        }
        [TestMethod]
        public void AddLocationDepartment()
        {
            try
            {
                ILocationDepartment locationDepartment = new LocationDepartment();
                locationDepartment.DepartmentId = Guid.NewGuid();
                locationDepartment.DepatmentName = "Cracking4";
                ltr.Create((LocationDepartment)locationDepartment);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void UpdateLocationDepartment()
        {
            try
            {
                ILocationDepartment locationDepartment = new LocationDepartment();
                locationDepartment.DepartmentId = Guid.Parse("9EBA6D35-66D7-4905-8D2D-34F772D03733");
                locationDepartment.DepatmentName = "Light2";
                ltr.Update((LocationDepartment)locationDepartment);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void GetDepartmet()
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