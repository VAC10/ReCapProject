using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userservice;

        public UsersController(IUserService userservice)
        {
            _userservice = userservice;
        }

        [HttpGet("getall")]
        public ActionResult <User> Get()
        {
            var result = _userservice.GetAll();
            if(result.Success) {

                return Ok (result);
            }
            return BadRequest(result);
            
        }
        [HttpPost("add")]
        public ActionResult Post(User user)
        {
            var result=_userservice.Add(user);
            if(result.Success)
            {
                return Ok (result.Message);

            }
            return BadRequest(result.Message);


        }
        [HttpPost("delete")]
        public ActionResult Delete(User user)
        {
            var result = _userservice.Delete(user);
            if(result.Success) { 
            return Ok
                    (result.Message);   
            
            }

            return BadRequest(result.Message);


        }
        [HttpPost("update")]
        public ActionResult Update(User user)
        {
          var result=_userservice.Update(user);
            if(result.Success)
            {
                return Ok(result.Message);

            }
            return BadRequest(result.Message);
            

        }





    }


}



