//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pecarnya
{
    using System;
    using System.Collections.Generic;
    
    public partial class Wares
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Wares()
        {
            this.ReceiptWares = new HashSet<ReceiptWares>();
            this.WaresIngredients = new HashSet<WaresIngredients>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Quantity { get; set; }
        public decimal Price { get; set; }
        public Nullable<int> IngredientId { get; set; }
    
        public virtual Ingredients Ingredients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiptWares> ReceiptWares { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WaresIngredients> WaresIngredients { get; set; }
    }
}
