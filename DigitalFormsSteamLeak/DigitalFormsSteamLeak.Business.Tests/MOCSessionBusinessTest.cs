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
    public class MOCSessionBusinessTest
    {
        protected MOCSessionFactory ltr { get; set; }

        public MOCSessionBusinessTest()
        {
            ltr = new MOCSessionFactory();
        }
        [TestMethod]
        public void AddMOCSession()
        {
            try
            {
                IMOCSession mocSesseion = new MOCSession()
                {
                    MOCId = Guid.NewGuid(),
                    LeakDetailsId = Guid.Parse("C124835B-4B82-4CAB-A173-44601AC73012"),
                    MOCNumber = 123,
                    MOCDateRequested = DateTime.Now,
                    MOCStatus = "start",
                    MOCComments = "Dustin make MOC comments",
                };
                ltr.Create((MOCSession)mocSesseion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void UpdateMOCSession()
        {
            try
            {
                IMOCSession mocSesseion = new MOCSession()
                {
                    MOCId = Guid.Parse("23BB161F-6402-4096-A2C7-75D82F6F4C53"),
                    LeakDetailsId = Guid.Parse("C124835B-4B82-4CAB-A173-44601AC73012"),
                    MOCNumber = 1233,
                    MOCDateRequested = DateTime.Now,
                    MOCStatus = "End",
                    MOCComments = "Dustin MOC comments",
                };
                ltr.Update((MOCSession)mocSesseion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]

        public void GetMOCSession()
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