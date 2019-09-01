using Microsoft.EntityFrameworkCore;
using SimleSurvey.Data.Interfaces;
using SimleSurvey.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimleSurvey.Data.Repository
{
    public class UserRepository : IAllUsers
    {
        public readonly AppDBContent appDBContent;

        public UserRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<User> AllUsers => appDBContent.User.Include(c => c.firstname);
    }
}
