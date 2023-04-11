﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ShopOnline2022.Models
{
    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [Key]
        public int OrderID { get; set; }
        [Key]
        public int ProductID { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }

        [ForeignKey("OrderID")]
        [InverseProperty("OrderDetails")]
        public virtual Order Order { get; set; }
        [ForeignKey("ProductID")]
        [InverseProperty("OrderDetails")]
        public virtual Product Product { get; set; }
    }
}