/*Tyler Wiggins
    This is my own work
    Assessment*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_247.Models
{
    public class foodModel
    {
        //Getters and setteres for our model/variables
        [Display(Name = "Please enter the name")]
        public string Name { get; set; }
        [Display(Name = "Please enter the amount of caleries")]
        public int Calories { get; set; }
        [Display(Name = "Please enter the first ingredient")]
        public string IngredientOne { get; set; }
        [Display(Name = "Please enter the last ingredient")]
        public string IngredientTwo { get; set; }

        //Constructors
        public foodModel(string Name, int Calories, string IngredientOne, string IngredientTwo)
        {
            this.Name = Name;
            this.Calories = Calories;
            this.IngredientOne = IngredientOne;
            this.IngredientTwo = IngredientTwo;
        }

        public foodModel()
        {

        }
    }
}
