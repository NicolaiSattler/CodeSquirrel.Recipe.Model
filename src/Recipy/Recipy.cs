﻿using System;
using System.Collections.Generic;

namespace CodeSquirl.RecipeApp.Model
{
    public class Recipe
    {
        public int ID { get; set; }
        public Guid UniqueID { get; set; }
        public Guid UserID { get; set; }
        public string Name { get; set; }
        public RecipyType Type { get; set; }
        public DietType Diet { get; set; }
        public IList<Ingredient> Ingredients { get; }
        public IList<Instruction> Instructions { get; }
        public TimeSpan Duration { get; }
        public bool AllowRemnants { get; set; }
        public bool Deleted { get; set; }

        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            Instructions = new List<Instruction>();
        }
    }
}
