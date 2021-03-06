﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WM.Core.Entities;
using WM.Northwind.Entities.Concrete.EczaneNobet;

namespace WM.Northwind.Entities.ComplexTypes.EczaneNobet
{
    public class EczaneNobetSonucNode : IComplexType
    {
        //Id: eczaneId
        public int Id { get; set; }
        public string Label { get; set; }
        public int Value { get; set; }
        public int Group { get; set; }
        public int Level { get; set; }
        public int NobetSonucDemoTipId { get; set; }
    }
}
