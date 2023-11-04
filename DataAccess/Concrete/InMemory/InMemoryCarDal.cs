using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
               new Car{BrandId=1,ColorId=2,DailyPrice=170000,Description=" Audi A4- hatasız tramer kaydı yok",Id=1,ModelYear=2017},
                new Car{BrandId=2,ColorId=1,DailyPrice=500000,Description=" Mustang gt- hatasız tramer kaydı yok",Id=2,ModelYear=1967},
                 new Car{BrandId=2,ColorId=1,DailyPrice=100000,Description=" Ford Focus- hatasız tramer kaydı yok",Id=3,ModelYear=2014},
                    new Car{BrandId=3,ColorId=2,DailyPrice=15000,Description=" Mercedes e250- hatasız tramer kaydı yok",Id=4,ModelYear=1997},
               };
        }
        public void Add(Car car)
        {
          _cars.Add(car);   
        }

        public void Delete(Car car)
        {


           Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);

            _cars.Remove(carToDelete);
    
          
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByCarsBrandId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByCarsColorId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByCategory(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<Car> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;    
            carToUpdate.BrandId = car.BrandId;  
            car.ColorId = car.ColorId;  
            car.DailyPrice = car.DailyPrice;    
            car.Description = car.Description;  
            car.ModelYear = car.ModelYear;  

        }

        List<CarDetailDto> ICarDal.GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
