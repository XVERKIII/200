
namespace Store
{
    using System;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;

    public partial class DataBaseEntities : DbContext
    {
        private static DataBaseEntities dataBase = new DataBaseEntities();
        public ObservableCollection<product> products;
        public DataBaseEntities()
            : base("name=DataBaseEntities")
        {
            products = new ObservableCollection<product>(product.ToList());
            products.CollectionChanged += Products_CollectionChanged;
        }

        private void Products_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            product.Add(e.NewItems[0] as Store.product);
        }

        public static DataBaseEntities GetEntities() => dataBase;
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<logAndPass> logAndPass { get; set; }
        public virtual DbSet<product> product { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<typeOfProduct> typeOfProduct { get; set; }
    }
}
