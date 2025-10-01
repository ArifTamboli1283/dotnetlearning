using MicrosSoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace StateManagemtApp.Models;

public class Customer
{
    public string Code { get; set; }
    public string Name { get; set; }
    public List<SelectListItem> OrgList { get; set; }

    public Customer()
    {
        this.OrgList = new List<SelectListItem>();
    }
}