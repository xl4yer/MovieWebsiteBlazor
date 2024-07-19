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
        public async Task<List<mov>> Movies()
        {
            var ret = await xservices.Movies();
            return ret;
        }
        [HttpGet]
        public async Task<List<mov>> Search(string search)
        {
            var ret = await xservices.Search(search);
            return ret;
        }

        [HttpGet]
        public async Task<List<mov>> Action()
        {
            var ret = await xservices.Action();
            return ret;
        }

        [HttpGet]
        public async Task<List<mov>> Adventure()
        {
            var ret = await xservices.Adventure();
            return ret;
        }

        [HttpGet]
        public async Task<List<mov>> Animation()
        {
            var ret = await xservices.Animation();
            return ret;
        }

        [HttpGet]
        public async Task<List<mov>> Comedy()
        {
            var ret = await xservices.Comedy();
            return ret;
        }

        [HttpGet]
        public async Task<List<mov>> Crime()
        {
            var ret = await xservices.Crime();
            return ret;
        }

        [HttpGet]
        public async Task<List<mov>> Documentary()
        {
            var ret = await xservices.Documentary();
            return ret;
        }

        [HttpGet]
        public async Task<List<mov>> Drama()
        {
            var ret = await xservices.Drama();
            return ret;
        }
    }
}
