
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;


namespace foodCloudProject.Models
{
    //[Table("Recipes")]
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }

        //[DisplayName("Description")]
        public string Description { get; set; }
        public string PrepInstructions { get; set; }
        //public List <RTag>RTags{ get; set; }

        //[ForeignKey("Id")]
        //public List<Ingredients> Ingredients { get; set; }

        //[ForeignKey("Id")]
        //public List<Instructions> Instructions { get; set; }
        public string ImageUrl { get; set; }
    }
}
