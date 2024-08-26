using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using RobertMonden.Website.Models;

namespace RobertMonden.Website.Shared
{
    public partial class NavMenu : ComponentBase
    {
        private List<MenuItem> _menuItems = new List<MenuItem>()
        {
            new MenuItem
            {
                Label = "Home",
                Href = "/",
                Icon = "home"
            },
            new MenuItem
            {
                Label = "Skills",
                Href = "skills",
                Icon = "brush"
            },
            new MenuItem
            {
                Label = "Education",
                Href = "education",
                Icon = "book"
            },
            new MenuItem
            {
                Label = "Biography",
                Href = "bio",
                Icon = "person"
            },
            new MenuItem
            {
                Label = "Resume",
                Href = "resume",
                Icon = "list"
            },
            new MenuItem
            {
                Label = "Contact",
                Href = "contact",
                Icon = "phone"
            }
        };
    }
}
