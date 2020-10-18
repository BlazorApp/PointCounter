using System.Collections.Generic;
using BlazorCounter.Data.Model;

namespace BlazorCounter.Data.Service
{
    public interface IUserServices
    {
        UserModel Save(UserModel user);
        List<UserModel> AllUser();
    }
}