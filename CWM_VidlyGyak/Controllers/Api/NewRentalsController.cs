using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using CWM_VidlyGyak.DTOS;
using CWM_VidlyGyak.Models;

namespace CWM_VidlyGyak.Controllers.Api
{
    
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDTO newRental) 
        {
            var custumer = _context.Custumers.Single(c => c.Id == newRental.CustumerID);

            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();
    
            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available.");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Custumer = custumer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _context.Rentals.Add(rental);
            };

            _context.SaveChanges();

            return Ok();
        }
    }
}
