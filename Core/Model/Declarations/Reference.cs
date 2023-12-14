// <copyright file="Reference.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace CodePlanter.Core.Model.Declarations
{
    using System.Collections.Generic;

    internal class Reference
    {
        public string Name { get; set; }

        public List<Entity> Entities { get; set; }
    }
}
