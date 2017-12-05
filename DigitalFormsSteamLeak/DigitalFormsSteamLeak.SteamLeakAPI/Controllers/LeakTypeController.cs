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
    public class LeakTypeController : ApiController
    {
        HttpResponseMessage response = new HttpResponseMessage();
        public LeakTypeFactory leakTypeFactory = new LeakTypeFactory();
        // GET: api/LeakType
        public HttpResponseMessage Get()
        {
            try
            {
                var result = leakTypeFactory.GetAll().ToList<ILeakType>();
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

        // GET: api/LeakType/5
        public HttpResponseMessage Get(Guid? id)
        {
            try
            {
                var result = leakTypeFactory.GetById(id);
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
            // return leakTypeFactory.GetById(id);
        }

        // POST: api/LeakType
        public HttpResponseMessage Post(LeakType leakType)
        {
            try
            {
                response.StatusCode = HttpStatusCode.Created;
                response.Content = new StringContent(leakTypeFactory.Create(leakType).ToString());
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

        // PUT: api/LeakType/5
        public HttpResponseMessage Put(LeakType leakType)
        {
            try
            {
                response.StatusCode = HttpStatusCode.Created;
                response.Content = new StringContent(leakTypeFactory.Update(leakType).ToString());
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

        // DELETE: api/LeakType/5
        public void Delete(int id)
        {
        }
    }
}