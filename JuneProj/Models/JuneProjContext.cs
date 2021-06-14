using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace JuneProj.Models
{
  public class JuneProjContext : DbContext
  {
    public JuneProjContext(DbContextOptions<JuneProjContext> options)
            : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Resource>()
        .HasData(

        );
    }
    public DbSet<Resource> Resources { get; set; }
  }
}