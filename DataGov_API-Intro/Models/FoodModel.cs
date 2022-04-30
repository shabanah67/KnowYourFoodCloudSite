using System.Collections.Generic;

namespace DataGov_API_Intro.Models
{
    public class FoodItem
    {
        public int fid { get; set; }
        public int amount { get; set; }
        public int datapoints { get; set; }
        public string min { get; set; }
        public int max { get; set; }
        public string type { get; set; }
        public List<FoodItem> FoodItems { get; set; }
    }

    public class SearchResultFood
    {
        public string fdcid { get; set; }
        public string datatype { get; set; }
        public string description { get; set; }
        public string foodcode { get; set; }
        public string brandowner { get; set; }
        public string ingredients { get; set; }
        public string score { get; set; }
        public string fid { get; set; }
        public List<FoodItem> FoodItems { get; set; }

    }
    public class Nutrient
    {
        public string nid { get; set; }
        public int number { get; set; }
        public string name { get; set; }
        public int rank { get; set; }
        public string unit_name { get; set; }
        public int fid { get; set; }
        public List<FoodItem> FoodItems { get; set; }
    }
    public class InputFoodFoundation
    {
        public int id { get; set; }
        public string fooddescription { get; set; }
        public string field { get; set; }
        public int fdcid { get; set; }
        public List<InputFood> InputFood { get; set; }
    }
    public class InputFood
    {
        public int fdcid { get; set; }
        public string datatype { get; set; }
        public string description { get; set; }
        public string foodclass { get; set; }
        public int fid { get; set; }
        public List<FoodItem> FoodItems { get; set; }
    }
    public class FoodNutrientDerivation
    {
        public int id { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string nid { get; set; }
        public List<Nutrient> Nutrients { get; set; }
    }
}
