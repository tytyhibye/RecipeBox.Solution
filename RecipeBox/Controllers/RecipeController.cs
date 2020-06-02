using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

//user directives
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace RecipeBox.Controllers
{
  [Authorize]
  public class RecipeController : Controller
  {
    private readonly RecipeBoxContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public RecipeController(UserManager<ApplicationUser> userManager, RecipeBoxContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Index()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      var userRecipes = _db.Recipes.Where(entry => entry.User.Id == currentUser.Id).ToList();
      return View(userRecipes);
    }

    public ActionResult Create()
    {
      ViewBag.TagId = new SelectList(_db.Recipes, "RecipeId", "Name");
      return View();
    }
  }
}