using Abstractions;
using SelfTest.Entities;
using System;

namespace SelfTest.Commands
{
    public class GetGeometricFormResponse : Response<GeometricForm>
    {
        public GetGeometricFormResponse(String name, decimal height, decimal width, decimal multiply)
        {
            Name = name;
            Height = height;
            Width = width;
            Multiply = multiply;
        }

        public String Name { get; set; }
        public Decimal Height { get; set; }
        public Decimal Width { get; set; }
        public Decimal Multiply { get; set; }
    }
}
