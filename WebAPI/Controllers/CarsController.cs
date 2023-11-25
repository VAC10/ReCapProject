using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    
    public class CarsController : ControllerBase
    {
        ICarService _carservice;

        public CarsController(ICarService carservice)
        {
            _carservice = carservice;
        }

        [HttpGet("getall")]
        public ActionResult <Car> Get()
        {
           var result=_carservice.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);

            }

            return BadRequest(result);

        }

        [HttpGet("getdetail")]

        public IActionResult GetDetail()
        {
            var result = _carservice.GetCarDetails();
            if(result.Success) { 
            return Ok(result.Data);
            }

            return BadRequest(result);





        }




        [HttpPost("add")]
        public IActionResult Post(Car car) {
            var result =_carservice.Add(car);
            if (result.Success) { 
            return Ok(result);  
            }
            return BadRequest(result);
        
        
        }



    }
}
