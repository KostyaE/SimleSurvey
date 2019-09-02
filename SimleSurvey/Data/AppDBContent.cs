using Microsoft.EntityFrameworkCore;
using SimleSurvey.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimleSurvey.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<User> User {set; get;}
        
        public DbSet<Survey> Survey { set; get; }

        public DbSet<Question> Question { set; get; }

    }
}
