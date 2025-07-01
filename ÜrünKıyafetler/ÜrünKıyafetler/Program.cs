using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Xml.Linq;
namespace ÜrünKıyafetler
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());
        }

        
    }

    public static class Id
    {
        public static int UserID;
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }
        public double Balance { get; set; }

    } // Kullanıcılar

    public abstract class Product
    {
        public string Size { get; set; }
        public double Price { get; set; }
        public int Id { get; set; }

        public string Type = "Sifir";

    } // Base Class
      
    public class Shirt : Product
    {
        public string sleve { get; set; } // Uzun Kol / Kısa kol
        public string Collar { get; set; } // Yaka
        public new string Type { get; set; }


        public int ConditionId { get; set; }
        public Condition Condition { get; set; }

        public int ProductColorId { get; set; }
        public ProductColor ProductColor { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int GenderId { get; set; }
        public Gender Gender { get; set; }

        public int FabricId { get; set; }
        public Fabric Fabric  { get; set; }



    } // Gömlek Class'ı
    public class Pants : Product
    {
        public int Waistsize {get; set;}
        public int Length { get; set; }
        public new string Type { get; set; }

        public int ConditionId { get; set; }
        public Condition Condition { get; set; }

        public int ProductColorId { get; set; }
        public ProductColor ProductColor { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int GenderId { get; set; }
        public Gender Gender { get; set; }

        public int FabricId { get; set; }
        public Fabric Fabric { get; set; }


    } // Pantolon Class'ı
    public class Jacket : Product
    {
        public string Hood { get; set; }
        public string Pocket { get; set; }
        public new string Type { get; set; }

        public int ConditionId { get; set; }
        public Condition Condition { get; set; }

        public int ProductColorId { get; set; }
        public ProductColor ProductColor { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int GenderId { get; set; }
        public Gender Gender { get; set; }

        public int FabricId { get; set; }
        public Fabric Fabric { get; set; }

    } // Mont Class'ı 
    public class Tshirt : Product
    {
        public string sleve { get; set; } // Uzun Kol / Kısa kol
        public string Collar { get; set; }

        public new string Type { get; set; }

        public int ConditionId { get; set; }
        public Condition Condition { get; set; }

        public int ProductColorId { get; set; }
        public ProductColor ProductColor { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int GenderId { get; set; }
        public Gender Gender { get; set; }

        public int FabricId { get; set; }
        public Fabric Fabric { get; set; }


    } // TiSort Class'ı





    public class Condition
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Shirt> Shirts { get; set; }
        public List<Pants> pants { get; set; }
        public List<Jacket> Jackets { get; set; }
        public List<Tshirt> Tshirts { get; set; }

    } // Sifir mi
    public class ProductColor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Shirt> Shirts { get; set; } 
        public List<Pants> pants { get; set; }
        public List<Jacket> Jackets { get; set; }
        public List<Tshirt> Tshirts { get; set; } 


    } // Renk Classı 
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Shirt> Shirts { get; set; }
        public List<Pants> pants { get; set; }
        public List<Jacket> Jackets { get; set; }
        public List<Tshirt> Tshirts { get; set; }
    } // Marka classı
    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Shirt> Shirts { get; set; }
        public List<Pants> pants { get; set; }
        public List<Jacket> Jackets { get; set; }
        public List<Tshirt> Tshirts { get; set; }
    } // Cinsiyet Classı
    public class Fabric
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Shirt> Shirts { get; set; }
        public List<Pants> pants { get; set; }
        public List<Jacket> Jackets { get; set; }
        public List<Tshirt> Tshirts { get; set; }

    } // Kumas classı 


    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" Server = AHMETALI\\SQLEXPRESS; Database = TekstilProjesi ; Integrated Security = True; TrustServerCertificate = true");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Shirt> Shirts { get; set; }
        public DbSet<Pants> pants { get; set; }
        public DbSet<Jacket> Jackets { get; set; }
        public DbSet<Tshirt> Tshirts { get; set; }

        public DbSet<Condition> Conditions { get; set; }
        public DbSet<ProductColor> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Fabric> Fabrics { get; set; }
        public DbSet<Gender> Genders { get; set; }
    }

}