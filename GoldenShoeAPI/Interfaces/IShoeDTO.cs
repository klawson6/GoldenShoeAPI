﻿using System;
using System.Collections.Generic;
using GoldenShoeAPI.Domain;

namespace GoldenShoeAPI.Interfaces
{
    public interface IShoeDTO
    {
        public int ShoeId { get; set; }
        public string Name { get; set; }
        public Brand Brand { get; set; }
        public string Description { get; set; }
        public Style Style { get; set; }
        public double Price { get; set; }
        public IList<Colour> Colours { get; set; }
        public IList<ShoeSize> Sizes { get; set; }
    }
}
