using BlazorCounter.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using BlazorCounter.Data;
using System.Threading.Tasks;

namespace BlazorCounter.Data.Service
{
    public class UserServices: DataContext<UserModel>, IUserServices
    {
        public UserServices(): base()
        {
        }

        public UserModel Save(UserModel user)
        {
            this.Insert(user);
            return user;
        }

        public List<UserModel> AllUser()
        {
            return this.GetAll();
        }
    }
}
