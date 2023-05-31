﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLearning.Contract.Dtos.Assets.Department
{
    public class AssetsDepartmentDto
    {
        public Guid Id { get; set; }

        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<AssetsDto> AssetsDto { get; set; }
    }
}
