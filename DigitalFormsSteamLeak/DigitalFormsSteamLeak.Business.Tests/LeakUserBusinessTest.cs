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
    public class LeakUserBusinessTest
    {
        protected LeakUserFactory ltr { get; set; }
        public LeakUserBusinessTest()
        {
            ltr = new LeakUserFactory();
        }
        [TestMethod]
        public void AddLeakUser()
        {
            try
            {
                ILeakUser leakUser = new LeakUser();
                leakUser.UserId = Guid.NewGuid();
                leakUser.UserName = "User5";

                ltr.Create((LeakUser)leakUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void UpdateUser()
        {
            try
            {
                ILeakUser leakUser = new LeakUser();
                leakUser.UserId = Guid.Parse("47EAD6D9-C95F-4592-B5C4-229E19D13E7A");
                leakUser.UserName = "Test5";
                ltr.Update((LeakUser)leakUser);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void GetUser()
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