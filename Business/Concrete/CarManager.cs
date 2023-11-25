using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

     

        public IDataResult<List<Car>>GetAll()
        {
            if (DateTime.Now.Hour==14)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime); 

            }
            return new DataSuccessResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);



        }

        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
            {  
            };
        }



    

       public  IDataResult<List<CarDetailDto>>GetCarDetails()
        {
            if (DateTime.Now.Hour == 19)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);

            }

            return new DataSuccessResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }
    }
}