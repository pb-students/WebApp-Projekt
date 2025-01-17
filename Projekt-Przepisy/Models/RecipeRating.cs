﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Przepisy.Models
{
    /// <summary>
    /// Entity of table Ratings.
    /// </summary>
    public class RecipeRating
    {
        [KeyAttribute]
        public int RecipeID { get; set; }
        [KeyAttribute]
        [MaxLength(450)]
        public string UserID { get; set; }

        // RatingIsPositive
        public bool IsPositive { get; set; }

        public RecipeRating(int recipeID, string userID, bool isPositive)
            => (RecipeID, UserID, IsPositive) = (recipeID, userID, isPositive);
    }
}
