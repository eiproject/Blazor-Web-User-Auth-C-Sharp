using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UserAuth.Models {
  public class User : IUser{
    private string _email;
    private string _password;
    private Encryption _encrypt;
    internal User(Encryption encrypt) {
      _encrypt = encrypt;
    }
    void IUser.SetUser(string email, string password) {
      _email = email; 
      _password = _encrypt.EncryptPassword(password);
    }
    string IUser.GetEmail() {
      return _email;
    }
    string IUser.GetPassword() {
      return _password;
    }
  }
}
