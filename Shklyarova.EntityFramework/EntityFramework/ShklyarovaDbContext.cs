﻿using Abp.EntityFramework;
using System.Data.Entity;
using Shklyarova.TestEntries;

namespace Shklyarova.EntityFramework
{
    public class ShklyarovaDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...
        public virtual IDbSet<TestEntry> TestEntries { get; set; }
        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ShklyarovaDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ShklyarovaDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ShklyarovaDbContext since ABP automatically handles it.
         */
        public ShklyarovaDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
    }
}
