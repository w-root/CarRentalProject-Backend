using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);

        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);

        IResult Update(User user,string password);

    }
}
