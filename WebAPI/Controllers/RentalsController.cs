using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalservice;

        public RentalsController(IRentalService rentalservice)
        {
            _rentalservice = rentalservice;
        }
        [HttpGet("getall")]

        public IDataResult<List<Rental>> Getall()
        {
            var result = _rentalservice.GetAll();
            return result;


        }





        [HttpPost("add")]

        public ActionResult Add(Rental rental)
        {
            var result=_rentalservice.Add(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }





    }
}
