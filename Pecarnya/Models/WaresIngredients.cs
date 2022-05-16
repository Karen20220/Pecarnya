namespace Pecarnya.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WaresIngredients
    {
        public int Id { get; set; }

        public int WaresId { get; set; }

        public int IngredientsId { get; set; }

        public int Quantity { get; set; }

        public virtual Wares Wares { get; set; }
    }
}
