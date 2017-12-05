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
    public class ScaffoldSessionBusinessTest
    {
        protected ScaffoldSessionFactory ltr { get; set; }
        public ScaffoldSessionBusinessTest()
        {
            ltr = new ScaffoldSessionFactory();
        }

        [TestMethod]
        public void AddScaffoldSession()
        {
            try
            {
                IScaffoldSession scaffoldSession = new ScaffoldSession()
                {
                    ScaffoldId = Guid.NewGuid(),
                    LeakDetailsId = Guid.Parse("C124835B-4B82-4CAB-A173-44601AC73012"),
                    ScaffoldType = "on Rent",
                    ScaffoldWidth = 2.2f,
                    ScaffoldLength = 2.2f,
                    ScaffoldHeight = 2.2f,
                    Legs = 4,
                    Decks = 4,
                    LGFt = 8.8f,
                    FT2 = 8.8f,
                    ScaffoldTagNumber = 1234,
                    BWANumber = 1234,
                    BWARequestCreatedDate = DateTime.Now,
                    BWARequestStartDate = DateTime.Now,
                    BWARequestEndDate = DateTime.Now,
                    BWAComments = "Bwa Comments",
                    MWANumber = 4767,
                    MWARequestCreatedDate = DateTime.Now,
                    MWARequestStartDate = DateTime.Now,
                    MWARequestEndDate = DateTime.Now,
                    MWAComments = "ssdfsdfa",
                    DWANumber = 3930,
                    DWARequestCreatedDate = DateTime.Now,
                    DWARequestStartDate = DateTime.Now,
                    DWARequestEndDate = DateTime.Now,
                    DWAComments = "dfsdfgdfgdfgdfgdfgdfgsdd"

                };

                ltr.Create((ScaffoldSession)scaffoldSession);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void UpdateScaffoldSession()
        {
            try
            {
                IScaffoldSession scaffoldSession = new ScaffoldSession()
                {
                    ScaffoldId = Guid.Parse("6278A10C-9EA5-414B-9974-6D3CDDBE6EF8"),
                    LeakDetailsId = Guid.Parse("C124835B-4B82-4CAB-A173-44601AC73012"),
                    ScaffoldType = "on Rent",
                    ScaffoldWidth = 2.2f,
                    ScaffoldLength = 2.2f,
                    ScaffoldHeight = 2.2f,
                    Legs = 4,
                    Decks = 4,
                    LGFt = 8.8f,
                    FT2 = 8.8f,
                    ScaffoldTagNumber = 1234,
                    BWANumber = 1234,
                    BWARequestCreatedDate = DateTime.Now,
                    BWARequestStartDate = DateTime.Now,
                    BWARequestEndDate = DateTime.Now,
                    BWAComments = "Bwa Comments",
                    MWANumber = 4767,
                    MWARequestCreatedDate = DateTime.Now,
                    MWARequestStartDate = DateTime.Now,
                    MWARequestEndDate = DateTime.Now,
                    MWAComments = "sdfsdfsdfsdfa",
                    DWANumber = 3930,
                    DWARequestCreatedDate = DateTime.Now,
                    DWARequestStartDate = DateTime.Now,
                    DWARequestEndDate = DateTime.Now,
                    DWAComments = "dfsdfsd"

                };

                ltr.Update((ScaffoldSession)scaffoldSession);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void GetScaffoldSession()
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