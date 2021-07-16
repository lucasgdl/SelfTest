using System.ComponentModel;

namespace SelfTest.Entities
{
    public enum EGeometricForm
    {
        [Description("Rect")]
        Rect = 1,

        [Description("Rect Triangle")]
        RectTriangle = 2,

        [Description("Ellipse")]
        Ellipse = 3
    }
}
