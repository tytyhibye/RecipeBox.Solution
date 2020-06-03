using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

//user directives
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace RecipeBox.Controllers
{
  
  public class RecipesController : Controller
  {
    private readonly RecipeBoxContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public RecipesController(UserManager<ApplicationUser> userManager, RecipeBoxContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public ActionResult Index() //async Task<>
    {
      List<Recipe> model = _db.Recipes.ToList();
      return View(model);
    }

    [Authorize]
    public ActionResult Create()
    {
      ViewBag.TagId = new SelectList(_db.Tags, "TagId", "Name");
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(Recipe recipe, int TagId)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      recipe.User = currentUser;
      _db.Recipes.Add(recipe);
      if (TagId != 0)
      {
        _db.RecipeTag.Add(new RecipeTag() { TagId = TagId, RecipeId = recipe.RecipeId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    [Authorize]
    public ActionResult Details(int id)
    {
      var thisRecipe = _db.Recipes
        .Include(recipe => recipe.Tags)
        .ThenInclude(join => join.Tag)
        .Include(recipe => recipe.User)
        .FirstOrDefault(recipe => recipe.RecipeId == id);
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ViewBag.IsCurrentUser = userId != null ? userId == thisRecipe.User.Id : false;
      return View(thisRecipe);
    }

    public ActionResult Edit(int id)
    {
      var thisRecipe = _db.Recipes.FirstOrDefault(recipes => recipes.RecipeId == id);
      ViewBag.TagId = new SelectList(_db.Tags, "TagId", "Name");
      return View(thisRecipe);
    }

    [HttpPost]
    public ActionResult Edit(Recipe recipe, int TagId)
    {
      if (TagId != 0)
      {
        _db.RecipeTag.Add(new RecipeTag() { TagId = TagId, RecipeId = recipe.RecipeId});
      }
      _db.Entry(recipe).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddTag(int id)
    {
      var thisRecipe = _db.Recipes.FirstOrDefault(recipes => recipes.RecipeId == id);
      ViewBag.TagId = new SelectList(_db.Tags, "TagId", "Name");
      return View(thisRecipe);
    }

    // bool checkDuplicateTag(DataTable table, int TagId)
    // {
    //   Recipe recipe = new Recipe();
    //   foreach (DataRow row in table.Rows)
    //   {
    //     if(row[2].Equals(recipe.RecipeId) && row[3].Equals(TagId))
    //     return true;
    //   }
    //   return false;
    // }
    //
    // if(!checkDuplicateTag(recipeId, TagId))
    //     { execute function }


    [HttpPost]
    public ActionResult AddTag(Recipe recipe, int TagId)
    {
      // var thisTagId = _db.RecipeTag.FirstOrDefault(recipeTag => recipeTag.TagId == TagId);
      // Console.WriteLine(TagId + " Tags Table Id");
      // Console.WriteLine(thisTagId + "ThisTagId");
      if (thisTagId != 0 ) //null
      {
      //   Console.WriteLine("That's a duplicate!");
      //   return View();
      // }
      // else{
      _db.RecipeTag.Add(new RecipeTag() { TagId = TagId, RecipeId = recipe.RecipeId }); 
      _db.SaveChanges();
      return RedirectToAction("Index");
      }
    }

    /*  
    Entity Framework Attempt to find duplicates  
    --------------------------------------------     
    if (db.Orderss.Any(o => o.Transaction == txnId)) return;
    if (RecipeTag.Any(o => o.TagId = TagId))

    This returns the first time the recipeId is met
    --------------------------------------------------
    var thisRecipeTag = _db.RecipeTag.FirstOrDefault(recipeTag => recipeTag.RecipeId == recipe.RecipeId);          
    
    ToDoList Lesson
    ---------------------------------------------------
    public async Task<ActionResult> AddCategory(int id)
    {
      Item thisItem = _db.Items.Where(entry => entry.User.Id == currentUser.Id).FirstOrDefault(items => items.ItemId == id);
      if (thisItem == null)
      {
        return RedirectToAction("Details", new {id = id});
      }
      ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
      return View(thisItem);
    }
    */  

    public ActionResult Delete(int id)
    {
      var thisRecipe = _db.Recipes.FirstOrDefault(recipes => recipes.RecipeId == id);
      return View(thisRecipe);
    }      

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisRecipe = _db.Recipes.FirstOrDefault(recipes => recipes.RecipeId == id);
      _db.Recipes.Remove(thisRecipe);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteTag(int joinId)
    {
      var joinEntry = _db.RecipeTag.FirstOrDefault(entry => entry.RecipeTagId == joinId);
      _db.RecipeTag.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpGet("/IngredientSearch")]
    public ActionResult IngredientSearch(string search)
    {
      List<Recipe> model = _db.Recipes.ToList();
      Recipe match = new Recipe();
      List<Recipe> matches = new List<Recipe>{};

      if (!string.IsNullOrEmpty(search))
      {
        foreach(Recipe recipe in model)
        {
          if (recipe.Ingredients.ToLower().Contains(search))
          {
            matches.Add(recipe);
          }
        } 
      }
      return View(matches);
    }
  }
}