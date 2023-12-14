// <copyright file="Solution.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace CodePlanter.Core.Model.Declarations
{
    using System.Collections.Generic;

    internal class Solution
    {
        public string Name { get; set; }

        public List<Project> Projects { get; set; }
    }
}
