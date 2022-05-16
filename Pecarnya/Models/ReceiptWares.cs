namespace Pecarnya.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReceiptWares
    {
        public int Id { get; set; }

        public int ReceiptId { get; set; }

        public int WaresId { get; set; }

        public int Quantity { get; set; }

        public virtual Receipt Receipt { get; set; }

        public virtual Wares Wares { get; set; }
    }
}
