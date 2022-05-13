using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ Id=1, BrandId=1, ColorId=1, DailyPrice=10, Description="asdas", ModelYear=2022},
                new Car{ Id=2, BrandId=2, ColorId=2, DailyPrice=100, Description="as", ModelYear=2021},
                new Car{ Id=3, BrandId=3, ColorId=3, DailyPrice=1000, Description="sa", ModelYear=2020},
                new Car{ Id=4, BrandId=4, ColorId=4, DailyPrice=10000, Description="sasa", ModelYear=2019},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car cartoDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(cartoDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int BrandId)
        {
            return _cars.Where(c => c.Id == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car cartoUpdate = _cars.SingleOrDefault(p => car.Id == car.Id);

            cartoUpdate.ModelYear = car.ModelYear;
            cartoUpdate.Description = car.Description;
            cartoUpdate.DailyPrice = car.DailyPrice;
            cartoUpdate.ColorId = car.ColorId;
            cartoUpdate.BrandId = car.BrandId;

        }
    }
}
