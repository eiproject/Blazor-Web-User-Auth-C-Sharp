using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserAuth.Models {
  public class UserLogic : IUserLogic {
    private IDatabase _database;
    private IUser _user;
    internal UserLogic(IDatabase database, IUser user) {
      _database = database; 
      _user = user;
    }
    void IUserLogic.CreateUser(string email, string password) {
      _user.SetUser(email, password);
      _database.AddUserToDatabase(_user);
    }

    void IUserLogic.ReadUser() {

    }

    void IUserLogic.UpdateUser() {

    }

    void IUserLogic.DeleteUser() {

    }
  }

}
