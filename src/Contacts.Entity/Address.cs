namespace Contacts.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Address")]
    public partial class Address
    {
        public Address()
        {
            CurrentResident = new HashSet<Person>();
            PermanentResident = new HashSet<Person>();
        }

        public Guid Id { get; set; }

        [StringLength(20)]
        public string House { get; set; }

        [StringLength(20)]
        public string Road { get; set; }

        [StringLength(20)]
        public string Area { get; set; }

        [StringLength(20)]
        public string District { get; set; }

        [StringLength(20)]
        public string Country { get; set; }

        public virtual ICollection<Person> CurrentResident { get; set; }

        public virtual ICollection<Person> PermanentResident { get; set; }
    }
}
