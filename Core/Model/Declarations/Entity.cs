// <copyright file="Entity.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace CodePlanter.Core.Model.Declarations
{
    using System.Collections.Generic;

    internal class Entity
    {
        public string Name { get; set; }

        public List<Property> Properties { get; set; }

        public List<Method> Methods { get; set; }
    }
}
