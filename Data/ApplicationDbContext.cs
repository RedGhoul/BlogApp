using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>()
                .HasMany(x => x.Blogs)
                .WithOne(x => x.AppUser)
                .HasForeignKey(x => x.AppUserId);

            builder.Entity<BlogTag>().HasKey(sc => new { sc.TagId, sc.BlogId });

            builder.Entity<Blog>().HasIndex(x => new { x.Content, x.Title }).IsFullText();

        }
    }
}
