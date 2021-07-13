using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserAuth.Models {
  interface IUser {
    void SetUser(string email, string password);
    string GetEmail();
    string GetPassword();
  }
}
