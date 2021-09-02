using Core.DataAccess;
using Entity.Concretes;
using Entity.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {

        List<CarDetailDto> GetCarDetails();

    }
}
