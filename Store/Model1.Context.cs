﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Store
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataBaseEntities : DbContext
    {
        private static DataBaseEntities dataBase = new DataBaseEntities();
        public DataBaseEntities()
            : base("name=DataBaseEntities")
        {
        }
        public static DataBaseEntities GetEntities() => dataBase;
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<logAndPass> logAndPass { get; set; }
        public virtual DbSet<product> product { get; set; }
    }
}