﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ShopOnline2022.Models
{
    [Table("ProductCategory")]
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int ProductCategoryID { get; set; }
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
        public int? ProductMainCategoryID { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; }

        [ForeignKey("CreateBy")]
        [InverseProperty("ProductCategories")]
        public virtual Account CreateByNavigation { get; set; }
        [ForeignKey("ProductMainCategoryID")]
        [InverseProperty("ProductCategories")]
        public virtual ProductMainCategory ProductMainCategory { get; set; }
        [InverseProperty("ProductCategory")]
        public virtual ICollection<Product> Products { get; set; }
    }
}