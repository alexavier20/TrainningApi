﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrainningApi.Domain.Entities
{
    [Serializable]
    public class ExampleItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
