﻿using DevFreela.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DevFreela.Infrastructure.Persistences
{
    public  class DevFreelaDbContext : DbContext
    {
        public DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options) : base(options){}

        public DbSet<Project> Projects { get;  set; }

        public DbSet<User> Users { get;  set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<Comment> Comments { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


    }
}