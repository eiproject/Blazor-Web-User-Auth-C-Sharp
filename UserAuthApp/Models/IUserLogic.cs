using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserAuth.Models {
  interface IUserLogic {
    void CreateUser(string email, string password);
    void ReadUser();
    void UpdateUser();
    void DeleteUser();
  }
}
