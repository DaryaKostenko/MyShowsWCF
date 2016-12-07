using System.Data.Entity;
using System.Runtime.Serialization;


namespace MyShowsParser
{
    [DataContract]
    class Context:DbContext
    {
        [DataMember]
        public DbSet<ShowModel> Shows { get; set; }
        [DataMember]
        public DbSet<CountryModel> Countries { get; set; }

        public Context() : base("MyDb")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShowModel>().HasOptional(x => x.Country).WithMany(x => x.Shows);
        }
    }
}
