using RentItAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentItAPI
{
    public class DBSeeder
    {
        private AppDbContext _dbContext;
        public DBSeeder(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
       public void Seed()
        {
            if(_dbContext.Database.CanConnect())
            {
                if(!_dbContext.Roles.Any())
                {
                    var roles = GetRoles();
                }
            }
        }

        private IEnumerable<Role> GetRoles()
        {
            var roles = new List<Role>()
            {
                new Role()
                {
                    Name = "Customer"
                },
                new Role()
                {
                    Name = "Admin"
                } 
            };
                return roles;
        }
    }
}

