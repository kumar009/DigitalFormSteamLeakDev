using DigitalFormsSteamLeak.Business;
using DigitalFormsSteamLeak.Entity.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Runtime.Serialization;
using DigitalFormsSteamLeak.Entity.Models;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json.Linq;

namespace DigitalFormsSteamLeak.SteamLeaksAPI.Controllers
{
    public class PortalInsulationReInstallSessionController : ApiController
    {
        HttpResponseMessage response = new HttpResponseMessage();
        public PortalInsulationReInstallSessionFactory portalInsulationReInstallSessionFactory = new PortalInsulationReInstallSessionFactory();
        // GET: api/PortalInsulationReInstallSession
        public HttpResponseMessage Get()
        {
            try
            {
                var result = portalInsulationReInstallSessionFactory.GetAll().ToList<IPortalInsulationReInstallSession>();
                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(JArray.FromObject(result).ToString());
                response.Headers.CacheControl = new CacheControlHeaderValue()
                {
                    MaxAge = TimeSpan.FromMinutes(20)
                };
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.Content = new StringContent(ex.Message);
                response.Headers.CacheControl = new CacheControlHeaderValue()
                {
                    MaxAge = TimeSpan.FromMinutes(20)
                };
            }
            return response;
        }

        // GET: api/PortalInsulationReInstallSession/5
        public HttpResponseMessage Get(Guid? id)
        {
            try
            {
                var result = portalInsulationReInstallSessionFactory.GetById(id);
                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(JArray.FromObject(result).ToString());
                response.Headers.CacheControl = new CacheControlHeaderValue()
                {
                    MaxAge = TimeSpan.FromMinutes(20)
                };
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.Content = new StringContent(ex.Message);
                response.Headers.CacheControl = new CacheControlHeaderValue()
                {
                    MaxAge = TimeSpan.FromMinutes(20)
                };
            }
            return response;
        }

        // POST: api/PortalInsulationReInstallSession
        public HttpResponseMessage Post(PortalInsulationReInstallSession portalInsulationReInstallSession)
        {
            try
            {
                response.StatusCode = HttpStatusCode.Created;
                response.Content = new StringContent(portalInsulationReInstallSessionFactory.Create(portalInsulationReInstallSession).ToString());
                response.Headers.CacheControl = new CacheControlHeaderValue()
                {
                    MaxAge = TimeSpan.FromMinutes(20)
                };
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.Content = new StringContent(ex.Message);
                response.Headers.CacheControl = new CacheControlHeaderValue()
                {
                    MaxAge = TimeSpan.FromMinutes(20)
                };
            }
            return response;
        }

        // PUT: api/PortalInsulationReInstallSession/5
        public HttpResponseMessage Put(PortalInsulationReInstallSession portalInsulationReInstallSession)
        {
            try
            {
                response.StatusCode = HttpStatusCode.Created;
                response.Content = new StringContent(portalInsulationReInstallSessionFactory.Update(portalInsulationReInstallSession).ToString());
                response.Headers.CacheControl = new CacheControlHeaderValue()
                {
                    MaxAge = TimeSpan.FromMinutes(20)
                };
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.Content = new StringContent(ex.Message);
                response.Headers.CacheControl = new CacheControlHeaderValue()
                {
                    MaxAge = TimeSpan.FromMinutes(20)
                };
            }
            return response;
        }

        // DELETE: api/PortalInsulationReInstallSession/5
        public void Delete(int id)
        {
        }
    }
}