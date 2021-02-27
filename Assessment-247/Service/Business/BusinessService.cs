/*Tyler Wiggins
    This is my own work
    Assessment*/
using Assessment_247.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_247.Service.Business
{
    public class BusinessService
    {
 
        //ShowFoodReverse method that reverses text
        public string ShowFoodReverse(foodModel food)
        {
            //turn IngredientOne and Ingredient2 into arrays
            char[] Ione = food.IngredientOne.ToCharArray();
            char[] Itwo = food.IngredientTwo.ToCharArray();

            //Mixed up blue string variables
            string blueString1 = "";
            string blueString2 = "";

            //for loop that reverses the array one letter at a time
            int x = Ione.Length;
            for (int y = 0; y < Ione.Length; y++)
            {
                x--;
                blueString1 += Ione[x];
            }

            //Reverses the array for the second Ingriedint
            x = Itwo.Length;
            for (int y = 0; y < Itwo.Length; y++)
            {
                x--;
                blueString2 += Itwo[x];
            }


            //Make new Food model with new ingredients and passes it back to the controller
            foodModel Bluemistake = food;
            Bluemistake.IngredientOne = blueString1;
            Bluemistake.IngredientTwo = blueString2;


            return blueString1 + blueString2+ Bluemistake;
        }
    }
}

