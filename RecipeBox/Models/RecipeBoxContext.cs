using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecipeBox.Models;

namespace RecipeBox.Models
{
  public class RecipeBoxContext : IdentityDbContext<ApplicationUser> 
  {
    public virtual DbSet<Tag> Tags { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<RecipeTag> RecipeTag { get; set; }
    public RecipeBoxContext(DbContextOptions options) : base(options) { }
    }
}