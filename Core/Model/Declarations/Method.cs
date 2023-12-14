// <copyright file="Method.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace CodePlanter.Core.Model.Declarations
{
    internal class Method
    {
        public string Name { get; set; }

        public string ReturnType { get; set; }

        public List<string> ParameterTypes { get; set; }
    }
}
