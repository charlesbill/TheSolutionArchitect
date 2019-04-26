# ASP.Net Core MVC Web Application using SQLite and Entity Framework Core

Here is the steps and command lines (CLI) on Visual Studio Code terminal: 
1) Ensure the SQLite package are included:
 dotnet add package Microsoft.EntityFrameworkCore.Sqlite 
2) Create the Model class, called Product in Models folder.

    public class Product
   {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduct { get; set; }

        [Display(Name = "Enter Product Code")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} Is required.")]
        public string ProductCode { get; set; }
        
        [Display(Name = "Enter Product Type")]
        [StringLength(50)]
        [Required(ErrorMessage = "{0} Is required.")]
        public string ProductType { get; set; }
        
        [Display(Name = "Enter Product Description")]
        [StringLength(150)]
        public string Description { get; set; }
        
        [Display(Name = "Unit Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Required(ErrorMessage = "{0} is required.")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Quantity in Stock")]
        [Required(ErrorMessage = "{0} Is required.")]
        public int QtyInStock { get; set; }
    }

3) Create a new DbContext class, in the Data. 

    public class MvcWebAppDbContext : DbContext
    {
        public MvcWebAppDbContext(DbContextOptions<MvcWebAppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set;}
    }
    
4) Update appsettings.json file and add the following connection straing
 
  "ProductsConnection": "DataSource=products.db"
  
5)To create the database, run the following commands in Terminal

  dotnet ef migrations add InitialCreate --context MvcWebAppDbContext
  dotnet ef database update
  
6) To create the Controllers and Views using the aspnet code genration tool, enter the following commands

  dotnet tool install -g dotnet-aspnet-codegenerator
  dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
  dotnet restore
  
  dotnet aspnet-codegenerator controller -name ProductsController -m Product -dc MvcWebAppDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

7) Build and run

  dotnet restore
  dotnet build
  
8) In Visual Studio Code, go to Debug and click run 

9) Remember, at this stage the new views are not added to your project. When the web application open in the URL, 
   change the URL to the following URL: localhost:5000/Products/Index
   
   
