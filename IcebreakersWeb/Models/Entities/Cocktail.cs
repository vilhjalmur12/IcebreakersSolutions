using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IcebreakersWeb.Models.Entities
{
    public class Cocktail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public virtual AlcaholCategory Category { get; set; }
        
        public string ImageSource { get; set; }

        

    }

}