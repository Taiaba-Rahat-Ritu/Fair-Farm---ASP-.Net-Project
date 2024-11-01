﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class ColdStorageItemList
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string CropsName { get; set; }
        [Required]
        public decimal CropsQuantity { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public string Region { get; set; }

        [Required]
        public decimal TotalRent { get; set; }

        [ForeignKey("RequestTable")]
        public int RequestId { get; set; }
        public virtual RequestTable RequestTable { get; set; }
    }
}
