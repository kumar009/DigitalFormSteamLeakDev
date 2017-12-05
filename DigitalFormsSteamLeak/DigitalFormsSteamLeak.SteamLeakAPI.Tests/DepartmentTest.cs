using DigitalFormsSteamLeak.Business;
using DigitalFormsSteamLeak.Entity.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFormsSteamLeak.SteamLeakAPI.Tests
{
    [TestClass]
    public class DepartmentTest
    {
        public LocationDepartmentFactory dFactory { get; set; }
        public LocationBusinessFactory bFactory { get; set; }
        public LocationUnit uFactory { get; set; }

        public DepartmentTest()
        {
            dFactory = new LocationDepartmentFactory();
            bFactory = new LocationBusinessFactory();
            uFactory = new LocationUnit();
        }

        [TestMethod]
        public void CreateDepartment()
        {
            var department = new LocationDepartment() { DepartmentId = Guid.NewGuid(), DepatmentName = "Test Department" };
            dFactory.Create(department);
        }

        [TestMethod]
        public void UpdateDepartment()
        {
            var department = new LocationDepartment() { DepartmentId = Guid.Parse("D73554EA-A8A6-4779-8C91-051024F488F2"), DepatmentName = "Test update Department" };
            dFactory.Update(department);
        }

        [TestMethod]
        public void GetDepartment()
        {
            var list = dFactory.GetAll().ToList();
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void CreateBusiness()
        {
            var business = new LocationBusiness() { BusinessLocationId = Guid.NewGuid(), BusinessName = "Test Business", DepartmentId = Guid.Parse("1b367716-568a-6f43-a695-022699cee763") };
            bFactory.Create(business);
        }

        [TestMethod]
        public void CreateDeptBusiUnit()
        {
            var deptId = Guid.NewGuid();
            var busiId = Guid.NewGuid();
            var unitId = Guid.NewGuid();

            var unit = new LocationUnit() { UnitId = unitId, UnitName = "TEST Unit 2", BusinessLocationId = busiId };
            var business = new LocationBusiness() { BusinessLocationId = busiId, BusinessName = "Test Business 2", DepartmentId = deptId, Unit = new List<LocationUnit>() { unit } };
            var department = new LocationDepartment() { DepartmentId = deptId, DepatmentName = "Test Department 2", Business = new List<LocationBusiness>() { business } };

            dFactory.Create(department);
        }
    }
}
