using FantasyPortal.ApplicationLogic.Abstractions;
using FantasyPortal.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FantasyPortal.DataAccess.Repositories
{
  public class UserRepository : Repository<User>, IUserRepository
  {
    public UserRepository(FantasyPortalDbContext dbContext) : base(dbContext)
    {
    }

    public void AddUser(string userId)
    {
      this.Add(new User() { UserId = userId });
    }

    public bool CheckIfUserExists(string userId)
    {
      if (dbContext.Users.FirstOrDefault(user => user.UserId == userId) != null)
      {
        return true;
      }
      return false;
    }
  }
}
