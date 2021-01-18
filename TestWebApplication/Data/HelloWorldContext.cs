using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApplication.Data
{
    public class HelloWorldContext : DbContext
    {
        public DbSet<Message> messages { get; set; }
        public DbSet<User> users { get; set; }


        public HelloWorldContext(DbContextOptions<HelloWorldContext> options)
            : base(options)
        {
        }
    }



}
