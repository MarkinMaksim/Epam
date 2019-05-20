using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace NET.S._2019.Markin._15.DAL.DbService
{
    public class AcountStorageDB : DbContext
    {
        public AcountStorageDB()
            : base("DefaultConnection")
        {
            Database.SetInitializer<AcountStorageDB>
                (new DropCreateDatabaseIfModelChanges<AcountStorageDB>());
        }

        public DbSet<AcountModel> Acounts { get; set; }
    }
}
