using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            

            if (brand.BrandName.Length < 2)
            {

                return new ErrorResult(Messages.BrandNameInvalid);
            }

            else
            {
                _brandDal.Add(brand);
                return new SuccessResult(Messages.BrandAdded);

            }
        }

        public void Delete(Brand entity)
        {
            throw new NotImplementedException();
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Brand>>GetAll()
        {
            if(DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            }
            return new DataSuccessResult<List<Brand>>(_brandDal.GetAll(),Messages.BrandListed);
           
        }

        public IDataResult<List<Brand>> GetByCarsBrandId(int Id)
        {

            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            }
            return new DataSuccessResult<List<Brand>>(_brandDal.GetAll(b => b.BrandId == Id));




        }


        public List<Brand> GetByCategory(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
