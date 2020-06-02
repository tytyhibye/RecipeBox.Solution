using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public Recipe()
    {
      this.Tags = new HashSet<RecipeTag>();
    }

    public int RecipeId { get; set; }
    public string Name { get; set; }
    public string Ingredients { get; set; }
    public string Instructions { get; set; }
    public virtual ApplicationUser User { get; set; }
    public ICollection<RecipeTag> Tags { get; }
  }   
}