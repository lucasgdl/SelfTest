using SelfTest.Entities;

namespace SelfTest.Interfaces
{
    public interface IGeometry
    {
        EGeometricForm Name { get; set; }
        decimal Height { get; set; }
        decimal Width { get; set; }
        decimal Multiply(double value)
        {
            var area = Width * Height;

            return area * ((decimal)value);
        }
    }
}
