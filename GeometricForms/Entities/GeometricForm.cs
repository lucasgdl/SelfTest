using SelfTest.Interfaces;
using System;

namespace SelfTest.Entities
{
    public class GeometricForm : IGeometry
    {
        public GeometricForm(EGeometricForm name, decimal height, decimal width)
        {
            Name = name;
            Height = height;
            Width = width;
        }

        public EGeometricForm Name { get; set; }
        public Decimal Height { get; set; }
        public Decimal Width { get; set; }

        public Decimal Multiply { get; set; }
    }
}
