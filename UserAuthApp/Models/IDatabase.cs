using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserAuth.Models {
  interface IDatabase {
    void AddUserToDatabase(IUser newUser);
    string GetAllUser();
    bool IsUserAlreadyRegistered(string email);
  }
}
