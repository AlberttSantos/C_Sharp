using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dependencies.Model.Enums;

namespace Dependencies.Model.Entities
{
    abstract class Shape : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
