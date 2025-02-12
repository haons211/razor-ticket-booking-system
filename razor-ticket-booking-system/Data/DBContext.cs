using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razor_ticket_booking_system.Models;

namespace razor_ticket_booking_system.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<razor_ticket_booking_system.Models.TestModel> TestModel { get; set; } = default!;
    }
}
