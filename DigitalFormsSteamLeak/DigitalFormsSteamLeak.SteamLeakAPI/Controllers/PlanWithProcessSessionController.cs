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
    public class PlanWithProcessSessionController : ApiController
    {
        HttpResponseMessage response = new HttpResponseMessage();
        public PlanWithProcessSessionFactory planWithProcessSessionFactory = new PlanWithProcessSessionFactory();

        // GET: api/PlanWithProcessSession
        public HttpResponseMessage Get()
        {
            try
            {
                var result = planWithProcessSessionFactory.GetAll().ToList<IPlanWithProcessSession>();
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

        // GET: api/PlanWithProcessSession/5
        public HttpResponseMessage Get(Guid? id)
        {
            try
            {
                var result = planWithProcessSessionFactory.GetById(id);
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

        // POST: api/PlanWithProcessSession
        public HttpResponseMessage Post(PlanWithProcessSession planWithProcessSession)
        {
            try
            {
                response.StatusCode = HttpStatusCode.Created;
                response.Content = new StringContent(planWithProcessSessionFactory.Create(planWithProcessSession).ToString());
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

        // PUT: api/PlanWithProcessSession/5
        public HttpResponseMessage Put(PlanWithProcessSession planWithProcessSession)
        {
            try
            {
                response.StatusCode = HttpStatusCode.Created;
                response.Content = new StringContent(planWithProcessSessionFactory.Update(planWithProcessSession).ToString());
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

        // DELETE: api/PlanWithProcessSession/5
        public void Delete(int id)
        {
        }
    }
}