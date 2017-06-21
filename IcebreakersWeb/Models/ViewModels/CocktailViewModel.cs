using IcebreakersWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IcebreakersWeb.Models.ViewModels
{
    public class CocktailViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public AlcaholCategory Category { get; set; }
        public List<SelectListItem> AvailableCategories { get; set; }
        public List<Ingredient> Ingredients { get; set; }

    }
}