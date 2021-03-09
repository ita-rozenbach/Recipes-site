using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Recipe
    {
        public int codeRecipe { get; set; }
        public string nameRecipe { get; set; }
        public int codeCategory { get; set; }
        public int timeAtMinute { get; set; }
        public int LevelDifficulty { get; set; }
        public DateTime addRecipe { get; set; }
        public string ingredients { get; set; }
        public string Preparation { get; set; }
        public int userCode { get; set; }
        public string image { get; set; }
        public bool isShow { get; set; }
    }
}