using AutoMapper;
using CWM_VidlyGyak.DTOS;
using CWM_VidlyGyak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace CWM_VidlyGyak.Controllers.Api
{
    public class CustumersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustumersController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /Api/Custumers

        public IHttpActionResult GetCustumers(string query = null)
        {
            var custumersQuery = _context.Custumers
                .Include(c => c.MembershipType);

            if (!String.IsNullOrWhiteSpace(query))
                custumersQuery = custumersQuery.Where(c => c.Name.Contains(query));

            var custumerDTOs = custumersQuery
                .ToList()
                .Select(Mapper.Map<Custumer,CustumerDTO>);

            return Ok(custumerDTOs);
        }

        //GET /Api/Custumers/1

        public CustumerDTO GetCustumer(int id)
        {
            var custumer = _context.Custumers.SingleOrDefault(c => c.Id == id);

            if (custumer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Mapper.Map<Custumer,CustumerDTO>(custumer);
        }

        //POST /Api/Custumers
        [HttpPost]
        public IHttpActionResult CreateCustumer(CustumerDTO custumerDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var custumer = Mapper.Map<CustumerDTO, Custumer>(custumerDTO);
            _context.Custumers.Add(custumer);
            _context.SaveChanges();

            custumerDTO.Id = custumer.Id;
            return Created(new Uri(Request.RequestUri + "/" + custumer.Id), custumerDTO);
        }

        //PUT /Api/Custumers/1
        [HttpPut]
        public void UpdateCustumer(int id, CustumerDTO custumerDTO)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var custumerInDb = _context.Custumers.SingleOrDefault(c => c.Id == id);

            if (custumerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(custumerDTO, custumerInDb);

            _context.SaveChanges();
        }

        //DELETE /Api/Custumers/1
        [HttpDelete]
        public void DeleteCustumer(int id)
        {
            var custumerInDb = _context.Custumers.SingleOrDefault(c => c.Id == id);

            if (custumerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Custumers.Remove(custumerInDb);
            _context.SaveChanges();
        }
    }
}
