using Business.Concrete;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System.ComponentModel.Design;

namespace ConsoleUI
{
   class Program
    {
        static void Main(string[] args)
        {

            



            {
                // UserManagerDelete();

                // UserManagerGetAll();

                //BrandManagerTest();


                // UserManagerAddTest();

                //CarManagerTest();
                //RentalManagerTest();

            };

       
        }

        private static void RentalManagerTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            {

            };
            var result = rentalManager.Add(new Rental { Id = 3, CarId = 1, CustomerId = 3, RentDate="25-10-2023",ReturnDate="28-10-2023"});
            Console.WriteLine(result.Message);
        }

        private static void UserManagerDelete()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.Delete(new User { Id = 15});
            Console.WriteLine(result.Message);

        }

        private static void UserManagerGetAll()
        {

            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName + "/" + user.LastName);

            }
        }

        private static void BrandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetByCarsBrandId(2);

            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }



            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserManagerAddTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
          
          
            var result = userManager.Add(new User { Id = 3, FirstName = "mete", LastName = "öztürk" ,Email="öztürk@gmail.com",Password="8932145"});
            Console.WriteLine(result.Message);

          
      
        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result=carManager.GetCarDetails();

            if(result.Success==true) {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName+" /" +car.ColorName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }

           
        }
    }
}