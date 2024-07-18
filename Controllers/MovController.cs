using Microsoft.AspNetCore.Mvc;
using Mov.Models;
using Mov.Services;

namespace Mov.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MovController : Controller
    {
        MovServices xservices;

        public MovController(MovServices xservices)
        {
            this.xservices = xservices;
        }

        [HttpGet]
        public async Task<List<mov>> MovieList()
        {
            var ret = await xservices.MovieList();
            return ret;
        }
        [HttpGet]
        public async Task<List<mov>> MovSearch(string search)
        {
            var ret = await xservices.MovSearch(search);
            return ret;
        }
    }
}
