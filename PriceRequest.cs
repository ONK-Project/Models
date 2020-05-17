﻿using System;

namespace Models
{
    [Serializable]
    public class PriceRequest
    {
        public DateTime DateTime { get; set; }
        public double RessourceUsage { get; set; }
        public string UnitOfMeassure { get; set; }
    }
}