﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WM.Core.Entities;
using WM.Northwind.Entities.Concrete.Authorization;

namespace WM.Northwind.Entities.Concrete.EczaneNobet
{
    public class MenuAltRole : IEntity
    {
        public int Id { get; set; }
        public int MenuAltId { get; set; }
        public int RoleId { get; set; }

        public virtual MenuAlt MenuAlt { get; set; }
        public virtual Role Role { get; set; }
    }
}
