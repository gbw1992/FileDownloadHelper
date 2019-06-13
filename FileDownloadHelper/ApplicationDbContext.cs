using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileDownloadHelper
{
    class ApplicationDbContext : DbContext
    {


        public DbSet<Model.ImageInfo> ImageInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");

        }


    }
}
