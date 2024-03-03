using Microsoft.AspNetCore.Mvc;
using MNOServiceUpdateAPI.DbContextData;
using MNOServiceUpdateAPI.Models;
using MNOServiceUpdateAPI.Repo;

namespace MNOServiceUpdateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MNOController : Controller
    {
        private readonly MNOServiceDbContext _context;
        public MNOController(MNOServiceDbContext context)
        {
            _context = context;
        }

        [HttpPost("AddUserDMZ")]
        public async Task<ResponseDto> AddUser(RequestDto req)
        {
            var service = new MnoRepo(_context);
            var response = await service.AddData(req);
            return response;
        }

        [HttpPost("AddUserWrapper")]
        public async Task<ResponseDto> AddUserWrapper(RequestDto req)
        {
            var service = new MnoRepo(_context);
            var response = await service.AddWrapperData(req);
            return response;
        }
    }
}
