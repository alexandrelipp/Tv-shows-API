using DataLibrary.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tv_shows_API.Models;

namespace Tv_shows_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowsController : ControllerBase

    {
        private readonly ShowService _showService;

        public ShowsController(ShowService showService)
        {
            _showService = showService;

        }
        [HttpGet("/shows")]
        public ActionResult<List<Show>> GetAllShows()
        {
            return _showService.GetAllShows();
        }

        [HttpGet("/shows/{id}",Name = "GetOneShow")]
        public ActionResult<Show> GetOneShow(string id)
        {
            return _showService.GetOneShow(id);
        }

        [HttpPost("/shows")]
        public ActionResult<Show> InsertShow(Show show)
        {
            _showService.InsertShow(show);
            return CreatedAtRoute(nameof(GetOneShow), new { id = show.Id},show);
        }
    }
}
