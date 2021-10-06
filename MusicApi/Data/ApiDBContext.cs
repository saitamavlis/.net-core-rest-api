using Microsoft.EntityFrameworkCore;
using MusicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApi.Data
{
    public class ApiDBContext: DbContext
    {
        public ApiDBContext(DbContextOptions<ApiDBContext> options): base(options)
        {

        }
        public DbSet<Song> Songs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id=1, 
                    Title="November Rain",
                    Language="English",
                    Duration="11:20"
                },
                 new Song
                 {
                     Id = 2,
                     Title = "Laura",
                     Language = "Español",
                     Duration = "3:25"
                 }
                );

        }
    }
}
