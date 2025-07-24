using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Product
    {
        [Key]
        public string Name { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
    }

} 

//  dotnet aspnet-codegenerator controller -name ProductController -m MvcMovie.Models.Product -dc MvcMovie.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite
