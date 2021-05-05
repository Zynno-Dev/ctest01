using Microsoft.EntityFrameworkCore;
using MvcData.Models;

namespace MvcData.Data
{
    public class MvcDataContext : DbContext
    {
        public MvcDataContext(DbContextOptions<MvcDataContext> options)
            : base(options)
        {
        }

        public DbSet<Datos> Data { get; set; }
    }
}