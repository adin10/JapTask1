using NormativeCalculator.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Requests
{
   public class RecipeInsertRequest
    {
        public string RecipeName { get; set; }
        public string Description { get; set; }
        //public float TotalCost { get; set; }
        public DateTime CreatedDate { get; set; }
        public int MyUserId { get; set; }
        public int RecipeCategoryId { get; set; }
        public List<IngredientRecipeInsertRequest> Ingredients { get; set; }
    }
}
