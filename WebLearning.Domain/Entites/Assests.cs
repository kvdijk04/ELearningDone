﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLearning.Domain.Entites
{
    public class Assests
    {
        [Key]
        public string Id { get;set; }

        public string AssetId { get;set; }

        public string AssetName { get;set; }    

        public Guid AssetsCategoryId { get;set; }

        public Guid AssetsSubCategoryId { get;set; }

        public int Quantity { get; set; }
        
        public Guid AssetsDepartmentId { get; set; }

        public string Customer { get; set; }
        public string Manager { get; set; }

        public int AssetsStatusId { get; set; }

        public DateTime DateUsed { get; set; }


        public DateTime DateChecked { get; set; }

        public string Spec { get; set; }

        public string Note { get; set; }

        public AssetsCategory AssetsCategory { get; set; }

        public AssetsDepartment AssetsDepartment { get; set; }

        public AssetsStatus AssetsStatus { get; set; }
    }
}