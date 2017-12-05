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
    public class MalfunctionSessionBusinessTest
    {
        protected MalfunctionSessionFactory ltr { get; set; }
        public MalfunctionSessionBusinessTest()
        {
            ltr = new MalfunctionSessionFactory();
        }

        [TestMethod]
        public void AddMalfunctionSession()
        {
            try
            {
                IMalfunctionSession malfunctionSession = new MalfunctionSession()
                {
                    MalfunctionId = Guid.NewGuid(),
                    LeakDetailsId = Guid.Parse("C124835B-4B82-4CAB-A173-44601AC73012"),
                    MalfunctionComments = "malfunction 2",
                    IsLokRingJobRequired = "y",
                    IsBreakIn = "n",
                    IsTurnAroudItem = "n",
                    IsDownTimeRequired = "n",
                    IsManLiftRequired = "y",
                    IsFirstTimePump = "y",
                    IsInstallClampRequired = "y",
                    IsRePump = "y",
                    IsWirewrapRequired = "y",
                    OnHold = "y",


                };
                ltr.Create((MalfunctionSession)malfunctionSession);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void UpdateMalfunctionSession()
        {
            try
            {
                IMalfunctionSession malfunctionSession = new MalfunctionSession()
                {
                    MalfunctionId = Guid.Parse("7E900088-B42A-4708-A6C5-AE46C048E775"),
                    LeakDetailsId = Guid.Parse("C124835B-4B82-4CAB-A173-44601AC73012"),
                    MalfunctionComments = "malfunction updated",
                    IsLokRingJobRequired = "y",
                    IsBreakIn = "y",
                    IsTurnAroudItem = "y",
                    IsDownTimeRequired = "y",
                    IsManLiftRequired = "y",
                    IsFirstTimePump = "y",
                    IsInstallClampRequired = "y",
                    IsRePump = "y",
                    IsWirewrapRequired = "y",
                    OnHold = "y",


                };
                ltr.Update((MalfunctionSession)malfunctionSession);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void GetMalfunctionSession()
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