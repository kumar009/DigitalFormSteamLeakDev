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
    public class IsolationSessionController : ApiController
    {
        HttpResponseMessage response = new HttpResponseMessage();
        public IsolationSessionFactory isolationSessionFactory = new IsolationSessionFactory();

        // GET: api/IsolationSession
        public HttpResponseMessage Get()
        {
            try
            {
                var result = isolationSessionFactory.GetAll().ToList<IIsolationSession>();
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

        // GET: api/IsolationSession/5
        public HttpResponseMessage Get(Guid? id)
        {
            try
            {
                var result = isolationSessionFactory.GetById(id);
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

        // POST: api/IsolationSession
        public HttpResponseMessage Post(IsolationSession isolationSession)
        {
            try
            {
                response.StatusCode = HttpStatusCode.Created;
                response.Content = new StringContent(isolationSessionFactory.Create(isolationSession).ToString());
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

        // PUT: api/IsolationSession/5
        public HttpResponseMessage Put(IsolationSession isolationSession)
        {
            try
            {
                response.StatusCode = HttpStatusCode.Created;
                response.Content = new StringContent(isolationSessionFactory.Update(isolationSession).ToString());
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

        // DELETE: api/IsolationSession/5
        public void Delete(int id)
        {
        }
    }
}