using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApplicationKnjižnica.Models
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options)
            : base(options)
        { }

        public DbSet<Knjiga> Blogs { get; set; }
        
    }
    public class Knjiga
    {
        public int KnjigaId { get; set; }
        public string Naziv{ get; set; }
        public string Autor{ get; set; }
        public string ISBN { get; set; }
        public DateTime Datum_posudbe { get; set; }

    }



}
