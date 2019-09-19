﻿using System;
using Abp.Domain.Entities;

namespace MediHub.Touchee.Products
{
    public class Product:Entity<int>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

    }
}
