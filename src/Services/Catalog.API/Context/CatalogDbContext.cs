using MongoRepo.Context;

namespace Catalog.API.Context
{
    public class CatalogDbContext : ApplicationDbContext
    {
        private static readonly IConfiguration Configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build()
        
        private static readonly string ConnectionString = Configuration.GetConnectionString("Catalog.API");

        private static readonly string DatabaseName = Configuration.GetValue<string>("DatabaseName");
        
        public CatalogDbContext() : base(ConnectionString, DatabaseName)
        {

        }
    }
}
