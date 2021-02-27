/*Tyler Wiggins
    This is my own work
    Assessment*/
using Assessment_247.Models;
using Assessment_247.Service.Business;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_247.Controllers
{
    public class FoodController : Controller
    {
    public IActionResult Index()
        {
            return View("Menu");
        }

        [HttpPost]
        public IActionResult Menu()
        {

            //Make new model and adds data to it
            foodModel food = new foodModel();

            //Gets the form input and puts it into foodModel
            food.Name = Request.Form["Name"].ToString();
            food.Calories = Convert.ToInt32(Request.Form["Calories"].ToString());
            food.IngredientOne = Request.Form["IngredientOne"].ToString();
            food.IngredientTwo = Request.Form["IngredientTwo"].ToString();


            //Call business class and reverses the ingredients
            BusinessService businessLayer = new BusinessService();

            //Gets reversed string from business layer
            string ShowFoodReverse = businessLayer.ShowFoodReverse(food);

            //sends the results to a viewbag
            ViewBag.ShowFoodReverse = "Did you want " + food.IngredientOne + " and " + food.IngredientTwo+ " ?";

            //Refreshes the Menu page with the new viewbag message
            return View("Menu");
        }
}
}
