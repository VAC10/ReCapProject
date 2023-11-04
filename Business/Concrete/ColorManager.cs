using Business.Abstract;
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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color entity)
        {
            throw new NotImplementedException();
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }


        public List<Color> GetAll()
        {
           return _colorDal.GetAll();   
        }

        public List<Color> GetByCarsBrandId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetByCarsColorId(int Id)
        {
            return _colorDal.GetAll(p=>p.ColorId== Id); 
        }

        public List<Color> GetByCategory(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetColors(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
