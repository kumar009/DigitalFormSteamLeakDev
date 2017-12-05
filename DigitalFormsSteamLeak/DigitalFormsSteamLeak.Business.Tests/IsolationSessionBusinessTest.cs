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
    public class IsolationSessionBusinessTest
    {
        protected IsolationSessionFactory ltr { get; set; }
        public IsolationSessionBusinessTest()
        {
            ltr = new IsolationSessionFactory();
        }

        [TestMethod]
        public void AddIsolationSession()
        {
            try
            {
                IIsolationSession isolationSessoin = new IsolationSession()
                {
                    LeakIsolationId = Guid.NewGuid(),
                    LeakDetailsId = Guid.Parse("3AED254F-9ADC-4BE4-BFCD-659966C588A1"),
                    IsIsolationVerifed = "n",
                    IsolationVerifiedDate = DateTime.Now,
                    ReasonIsolationNotVerified = "PWP Process"
                };
                ltr.Create((IsolationSession)isolationSessoin);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void UpdateIsolationSession()
        {
            try
            {
                IIsolationSession isolationSessoin = new IsolationSession()
                {
                    LeakIsolationId = Guid.Parse("8EE69FBD-89B4-44D8-8B4A-AAA0C2B04797"),
                    LeakDetailsId = Guid.Parse("3AED254F-9ADC-4BE4-BFCD-659966C588A1"),
                    IsIsolationVerifed = "n",
                    IsolationVerifiedDate = DateTime.Now,
                    ReasonIsolationNotVerified = "PWP Process"
                };
                ltr.Update((IsolationSession)isolationSessoin);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void GetIsolationSession()
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