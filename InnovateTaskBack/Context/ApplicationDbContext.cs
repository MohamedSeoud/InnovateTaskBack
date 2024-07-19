using InnovateTaskBack.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<InvoiceDetails> InvoiceDetails { get; set; }
    public DbSet<Unit> Unit { get; set; }

    //protected override void OnModelCreating(ModelBuilder builder)
    //{
    //    base.OnModelCreating(builder);

    //    builder.Entity<InvoiceDetails>()
    //        .HasOne(e => e.Unit)
    //        .WithOne()
    //        .HasForeignKey(e => e.)
    //        .IsRequired()
    //        .OnDelete(DeleteBehavior.Restrict);

    //}
}