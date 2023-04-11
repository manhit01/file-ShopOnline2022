﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ShopOnline2022.Models
{
    [Table("ProductMainCategory")]
    public partial class ProductMainCategory
    {
        public ProductMainCategory()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }

        [Key]
        public int ProductMainCategoryID { get; set; }
        [StringLength(255)]
        public string Avatar { get; set; }
        [StringLength(255)]
        public string Thumb { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(4000)]
        public string Description { get; set; }
        public int? Position { get; set; }
        public bool? Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateTime { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; }

        [ForeignKey("CreateBy")]
        [InverseProperty("ProductMainCategories")]
        public virtual Account CreateByNavigation { get; set; }
        [InverseProperty("ProductMainCategory")]
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}