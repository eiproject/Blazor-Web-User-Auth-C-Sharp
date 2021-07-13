using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserAuth.Models {
  public class User : IUser{
    private string _email;
    private string _password;
    internal User() { }
    void IUser.SetUser(string email, string password) {
      _email = email; _password = password;
    }
    string IUser.GetEmail() {
      return _email;
    }
    string IUser.GetPassword() {
      return _password;
    }
  }
}
