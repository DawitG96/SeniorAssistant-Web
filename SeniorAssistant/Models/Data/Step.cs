﻿using LinqToDB.Mapping;
using System;

namespace SeniorAssistant.Models.Data
{
    public class Step : IHasTime
    {
        [PrimaryKey]
        [NotNull]
        public string Username { get; set; }

        [PrimaryKey]
        [NotNull]
        public DateTime Time { get; set; }
        
        public long Value { get; set; }
    }
}
