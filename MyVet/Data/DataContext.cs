using Microsoft.EntityFrameworkCore;
using MyVet.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Data
{
    public class DataContext : DbContext //Inherit
    {
        //Create a constructor ctor Tab(x2)
        public DataContext(DbContextOptions<DataContext> options) : base(options) //DbContextOptions is a BD based on DataContext named options and object option go to the BD constructor
        {
        }
        public DbSet<Owner> owners { get; set; } //Propiety DbSet, Model Owner and Colection Owners

        //Summary =>
        //We have a table Entity Owner with structure BD and our BD will have that structure
        //Pending... Define conection string where we are going to matriculate DB. (appsettings.json)

    }
}
