using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserAuth.Models {
  internal class UserDatabase : IDatabase {
    private List<IUser>_userDatabase = new List<IUser>();
    private static IDatabase _instance;
    private static Object _myLock = new Object();
    private UserDatabase() { }
    public static IDatabase GetInstance() {
      if (_instance == null) {
        lock (_myLock) {
          if (_instance == null) {
            _instance = new UserDatabase();
          }
        }
      }
      return _instance;
    }
    void IDatabase.AddUserToDatabase(IUser newUser) {
      _userDatabase.Add(newUser);
    }
    public string GetAllUser() {
      string allUserEmail = "";
    
      for (int i = 0; i < _userDatabase.Count; i++) {
        allUserEmail += _userDatabase[i].GetEmail() + ", ";
      }
      return allUserEmail;
    }

    bool IDatabase.IsUserAlreadyRegistered(string email) {
      IEnumerable<IUser> filteredData = _userDatabase.Where(data => data.GetEmail() == email);
      if (filteredData.Count() != 0) {
        return true;
      }
      else {
        return false;
      }
    }
    bool IDatabase.UserAuthentication(string email, string password, Encryption encrypt) {
      if (_instance.IsUserAlreadyRegistered(email)) {
        string databasePassword = CheckUserHashedPassword(email);
        if (encrypt.EncryptPassword(password) == databasePassword) {
          return true;
        }
        else {
          return false;
        }
      }
      else {
        Console.WriteLine("User doesn't exist.");
        return false;
      }
    }
    string CheckUserHashedPassword(string email) {
      IEnumerable<IUser> filteredData = _userDatabase.Where(data => data.GetEmail() == email);
      IUser currentUser = filteredData.First();
      return currentUser.GetPassword();
    }
  }
}
