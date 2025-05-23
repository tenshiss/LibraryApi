using LibraryApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LibraryApi.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public DbSet<Book> Books => Set<Book>();
    }
}