﻿using EduZbieracz.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduZbieracz.Domain.Entities
{
    public class Category:AuditableEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public ICollection<Post> Posts { get; set; }  
    }
}
