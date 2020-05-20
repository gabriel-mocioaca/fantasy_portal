using FantasyPortal.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyPortal.ApplicationLogic.Abstractions
{
  public interface IUserRepository : IRepository<User>
  {
    void AddUser(string userId);
    bool CheckIfUserExists(string userId);
  }
}
