using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandservice;

        public BrandsController(IBrandService brandservice)
        {
            _brandservice = brandservice;
        }

        [HttpGet("getAll")]
        public ActionResult <Brand> GetAll()
        {
            var result = _brandservice.GetAll();
            if (result.Success==true) {
                return Ok(result);
            
            }
            return BadRequest(result);


        }
        [HttpGet("getbrandid")]
        public ActionResult <Brand> GetCarsBrandId(int id)
        {
            var result = _brandservice.GetByCarsBrandId(id);
            if (result.Success) {
               return  Ok(result.Data);
            }
            return BadRequest(result.Data);


        }


       [HttpPost("add")]
        public ActionResult Add(Brand brand)
        {
            var result=_brandservice.Add(brand);    
            if(result.Success)
            {

                return Ok(result.Message);
                
            }
            return BadRequest(result.Message);

        }

       


    }




}
