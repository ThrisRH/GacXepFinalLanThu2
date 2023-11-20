
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace GacXep.Models
{

using System;
    using System.Collections.Generic;
    
public partial class BookDetail
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public BookDetail()
    {

        this.OrderDetails = new HashSet<OrderDetail>();

    }


    public int ProDeID { get; set; }

    public int ProID { get; set; }

    public int PubID { get; set; }

    public int AuthorID { get; set; }

    public int Pages { get; set; }

    public string Language { get; set; }

    public double Price { get; set; }

    public int RemainQuantity { get; set; }

    public Nullable<int> SoldQuantity { get; set; }

    public Nullable<int> ViewQuantity { get; set; }



    public virtual Author Author { get; set; }

    public virtual Book Book { get; set; }

    public virtual Publisher Publisher { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<OrderDetail> OrderDetails { get; set; }

}

}
