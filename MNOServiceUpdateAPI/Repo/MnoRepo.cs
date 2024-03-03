using Microsoft.AspNetCore.Mvc;
using MNOServiceUpdateAPI.DbContextData;
using MNOServiceUpdateAPI.Models;
using Mysqlx;

namespace MNOServiceUpdateAPI.Repo
{
    public class MnoRepo
    {
        private readonly MNOServiceDbContext _context;
        public MnoRepo(MNOServiceDbContext context)
        {
            _context = context;
        }
        public async Task<ResponseDto> AddData(RequestDto req)
        {
            try
            {
                //Get current date and time
                DateTime currentLocalDateTime = DateTime.Now;

                var payload = new MNOServiceTable
                {
                    accountnumber = req.accountnumber,
                    customerid = req.CIF,
                    phonenumber = req.phonenumber,
                    isexisting = "1",
                    datecreated = currentLocalDateTime
                };

                await _context.AddAsync(payload);
                var AddUsers = _context.SaveChanges();

                var response = new ResponseDto
                {
                    message = "success",
                    status = true
                };
                return response;
            } catch (Exception ex)
            {
                return new ResponseDto 
                {   message = "An error Occured",
                    status = false,                
                };
            }

        }

        public async Task<ResponseDto> AddWrapperData(RequestDto req)
        {
            var Response = await AddData(req);
            return Response;
        }

    }
}