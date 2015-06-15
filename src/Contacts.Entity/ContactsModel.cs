namespace Contacts.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContactsModel : DbContext
    {
        public ContactsModel()
            : base("name=ContactsModel")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Telephony> Telephonies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasMany(e => e.People)
                .WithOptional(e => e.PresentAddress)
                .HasForeignKey(e => e.PermanentAddressId);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.People1)
                .WithOptional(e => e.PermanentAddress)
                .HasForeignKey(e => e.PresentAddressId);

            modelBuilder.Entity<Email>()
                .Property(e => e.Provider)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Emails)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Telephonies)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);
        }
    }
}
