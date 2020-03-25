using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
     
        [Required]              //  Not nullable
        [MaxLength(255)]        //  255 varchar
        public string Name { get; set; }

        [Display(Name="Type de nourriture")]
        public CuisineType Cuisine{ get; set; }
    }
}
