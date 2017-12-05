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
    public class LeakUserController : ApiController
    {
        HttpResponseMessage response = new HttpResponseMessage();
        public LeakUserFactory leakUserFactory = new LeakUserFactory();

        // GET: api/User
        public HttpResponseMessage Get()
        {
            try
            {
                var result = leakUserFactory.GetAll().ToList<ILeakUser>();
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

        // GET: api/User/5
        public HttpResponseMessage Get(Guid? id)
        {

            try
            {
                var result = leakUserFactory.GetById(id);
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

        // POST: api/User
        public HttpResponseMessage Post(LeakUser leakUser)
        {
            try
            {
                response.StatusCode = HttpStatusCode.Created;
                response.Content = new StringContent(leakUserFactory.Create(leakUser).ToString());
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

        // PUT: api/User/5
        public HttpResponseMessage Put(LeakUser leakUser)
        {
            try
            {
                response.StatusCode = HttpStatusCode.Created;
                response.Content = new StringContent(leakUserFactory.Update(leakUser).ToString());
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

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}