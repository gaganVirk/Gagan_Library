using Gagan_Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gagan_Library.Data
{
    public class MvcContext : DbContext
    {
        public MvcContext(DbContextOptions<MvcContext> options) : base(options)
        {

        }
        public DbSet<Book> Book { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
    }
}
