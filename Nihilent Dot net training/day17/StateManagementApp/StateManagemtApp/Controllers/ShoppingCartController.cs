using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StateManagemtApp.Models;

namespace StateManagemtApp.Controllers;

partial class ShoppingCartController : Controller
{
    public IActionResult TempData()
    {
        TempData["userdetails"] = "Arif Tamboli";
        return RedirectToAction("Data", "Home");
    }

    public IActionResult Cart()
    {
        string json = null;
        json = HttpContext.Session.GetString("Cart");
        if (json != null)
        {
            Cart existingCart = JsonSerializer.Deserialize<Cart>(json);
            ViewData["mycart"] = existingCart;
        }
        return view();
    }
}