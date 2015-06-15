namespace Contacts.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        public Person()
        {
            Emails = new HashSet<Email>();
            Telephonies = new HashSet<Telephony>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public Guid? PresentAddressId { get; set; }

        public Guid? PermanentAddressId { get; set; }

        public virtual Address PresentAddress { get; set; }

        public virtual Address PermanentAddress { get; set; }

        public virtual ICollection<Email> Emails { get; set; }

        public virtual ICollection<Telephony> Telephonies { get; set; }
    }
}
