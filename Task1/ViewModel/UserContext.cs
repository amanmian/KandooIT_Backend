using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
//using System.Data.Entity;
using Task1.Models;

namespace Task1.ViewModel
{
    public class UserContext : DbContext
    {
        private IConfigurationRoot _config;

        public UserContext(IConfigurationRoot config, DbContextOptions options) : base(options)
        {
            _config = config;
        }


        public DbSet<UserDetails> userDetails { get; set; }
        public DbSet<UserTypes> userTypes { get; set; }
        public DbSet<PrimaryAddress> primaryAddress { get; set; }
        public DbSet<SecondaryAddress> secondaryAddress { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //optionsBuilder.UseSqlServer(_config["ConnectionStrings:MyLocalDB"]);
        }
    }
}











//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Data.Entity;
//using Task1.Models;
//using Microsoft.Extensions.Configuration;

//namespace Task1.ViewModel
//{
//    public class UserContext : DbContext
//    {
//        private IConfigurationRoot _config;

//        public UserContext(IConfigurationRoot config, DbContextOptions options) : base(options)  
//        {
//            _config = config;
//        }
//        // public UserContext() : base("name=MyLocalDB") { }
//        public DbSet<UserDetails> userDetails { get; set; }
//        public DbSet<UserTypes> userTypes { get; set; }
//        public DbSet<PrimaryAddress> primaryAddress { get; set; }
//        public DbSet<SecondaryAddress> secondaryAddress { get; set; }
//        public DbSet<Country> Countries { get; set; }
//        public DbSet<State> States { get; set; }
//        public DbSet<City> Cities { get; set; }

//        public UserContext() : base() { }
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json",
//                                              optional: true, reloadOnChange: true);
//            config = builder.Build();
//            optionsBuilder.UseSqlServer(config.GetConnectionString
//              ("ReadingContextConnection"));
//        }
//    }
//}
