﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bank.Models
{
    public class BankModel
    {
        public int id { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
    }
}