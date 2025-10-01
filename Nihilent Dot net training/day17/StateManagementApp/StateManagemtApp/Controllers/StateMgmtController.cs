using Microsoft.AspNetCore.Mvc;
using StateManagemtApp.Models;
using System.Reflection.Metadata.Ecma335;

public class StateMgmtController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
        Claim theClaim = new Claim()
        {
            Email = "",
            Password = ""
        };
    }
    [HttpPost]
    public IActionResult Login(Claim theClaim)
    {
        if (theClaim.Email == "Arif@gmail.com" && theClaim.Password == "Abcd")
        {
            return RedirectToAction("index", "customers");
        }
        return View(theClaim);
    }

    public IActionResult Register()
    {
        Customer newCustomer = new Customer();
        newCustomer.OrgList = PopulateOrgs();
        return View(newCustomer);
    }

    [HttpPost]
    public IActionResult Register(Customer theCustomer, string[] orgnizations)
    {
        theCustomer.OrgList = PopulateOrgs();
        foreach (SelectListItem item in theCustomer.OrgList)
        {
            if (item != null)
            {
                if (orgnizations.Contains(item.value))
                {
                    item.selected = true;
                }
            }
        }
        return RedirectToAction("Index");
    }

    public static List<SelectListItem> PopulateOrgs()
    {
        List<SelectListItem> items = new List<SelectListItem>();
        items.Add(new SelectListItem { Text = "NIHILENT", Value = "NIHILENT", Selected = false });
        items.Add(new SelectListItem { Text = "NEDBANK", Value = "NEDBANK", Selected = false });
        items.Add(new SelectListItem { Text = "COGNI", Value = "COGNI", Selected = false });
        items.Add(new SelectListItem { Text = "TAVISCA", Value = "TAVISCA", Selected = false });
        items.Add(new SelectListItem { Text = "WIPRO", Value = "WIPRO", Selected = false });
    }
}