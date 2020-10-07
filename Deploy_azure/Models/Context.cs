using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Deploy_azure.Models
{
    public class Context:DbContext
    {
        public Context():base("Server=tcp:deploy-azuredbserver.database.windows.net,1433;Initial Catalog=Deploy_azure_db;Persist Security Info=False;User ID=terry;Password=Vargas98;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        {

        }
        public DbSet<Person> People { get; set; }
    }
}
