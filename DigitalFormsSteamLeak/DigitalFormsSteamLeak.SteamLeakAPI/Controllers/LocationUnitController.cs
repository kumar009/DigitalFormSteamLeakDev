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
    public class LocationUnitController : ApiController
    {
        HttpResponseMessage response = new HttpResponseMessage();
        public LocationUnitFactory locationUnitFactory = new LocationUnitFactory();

        //Get: api/LocationUnit
        public HttpResponseMessage Get()
        {
            try
            {
                var result = locationUnitFactory.GetAll().ToList<ILocationUnit>();
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

        // GET: api/LocationUnit/5
        public HttpResponseMessage Get(Guid? id)
        {
            try
            {
                var result = locationUnitFactory.GetById(id);
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

        // POST: api/LocationUnit
        public HttpResponseMessage Post(LocationUnit locationUnit)
        {
            try
            {
                response.StatusCode = HttpStatusCode.Created;
                response.Content = new StringContent(locationUnitFactory.Create(locationUnit).ToString());
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

        // PUT: api/LocationUnit/5
        public HttpResponseMessage Put(LocationUnit locationUnit)
        {
            try
            {
                response.StatusCode = HttpStatusCode.Created;
                response.Content = new StringContent(locationUnitFactory.Update(locationUnit).ToString());
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

        // DELETE: api/LocationUnit/5
        public void Delete(int id)
        {
        }
        // GET: api/LocationUnit
        //public IEnumerable<ILocationUnit> Get()
        //{
        //    var result = locationUnitFactory.GetAll().ToList<ILocationUnit>();
        //    return result;
        //}

        //// GET: api/LocationUnit/5
        //public IQueryable<ILocationUnit> Get(Guid? id)
        //{
        //    return locationUnitFactory.GetById(id);
        //}

        //// POST: api/LocationUnit
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/LocationUnit/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/LocationUnit/5
        //public void Delete(int id)
        //{
        //}
    }
}