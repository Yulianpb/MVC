﻿using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Alumnos> Alumnos { get; set; }
    }
}
