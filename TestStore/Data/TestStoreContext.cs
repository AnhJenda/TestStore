using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestStore.Models;

namespace TestStore.Data
{
    public class TestStoreContext : DbContext
    {
        public TestStoreContext (DbContextOptions<TestStoreContext> options)
            : base(options)
        {
        }

        public DbSet<TestStore.Models.Product> Product { get; set; } = default!;
        public DbSet<TestStore.Models.Category> Category { get; set; } = default!;

        public DbSet<TestStore.Models.Customer> Customer { get; set; } = default!;

        public DbSet<TestStore.Models.Order> Order { get; set; } = default!;

        public DbSet<TestStore.Models.OrderDetail> orderDetail { get; set; } = default!;
    }
}
