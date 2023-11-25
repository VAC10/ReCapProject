using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   public class UserManager : IUserService
    {
        IUserDal _userDal;
      
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
              
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
        
    
            _userDal.Add(user);
                return new SuccessResult(Messages.UserAdded);
            
            
        }

        public IResult Delete(User user)
        {
            if(user.Id ==null) {

                return new ErrorResult(Messages.NotDeleted);
            }
            else
            {
                _userDal.Delete(user);
                return new SuccessResult(Messages.DeletedSuccess);

            }
            
        }

        public IDataResult<List<User>>GetAll()
        {
            return new DataSuccessResult<List<User>>(_userDal.GetAll(), Messages.UserListed);

        }

        public IResult Update(User user)
        {

 
                _userDal.Update(user);
                return new DataSuccessResult<List<User>>(Messages.UpdateAvailable);
           


        }


     
    }
}
