namespace Contacts.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Telephony")]
    public partial class Telephony
    {
        public Guid Id { get; set; }

        public int CountryCode { get; set; }

        public int CarrierCode { get; set; }

        public int SubscriberNumber { get; set; }

        public Guid PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}
