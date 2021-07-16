using SelfTest.Commands.Requests;
using SelfTest.Entities;
using SelfTest.Interfaces;
using System;

namespace SelfTest.Commands.Handlers
{
    public class GetGeometricFormHandler
    {
        public GetGeometricFormResponse Handle(GetGeometricFormRequest request)
        {
            double value = 0;
            decimal height = 0;
            decimal width = 0;

            switch (request.Name)
            {
                case EGeometricForm.Rect:
                    value = 1;
                    height = 4;
                    width = 12;
                    break;
                case EGeometricForm.RectTriangle:
                    value = 0.5;
                    height = 3;
                    width = 5;
                    break;
                case EGeometricForm.Ellipse:
                    value = Math.PI;
                    height = 2;
                    width = 7;
                    break;
            }

            IGeometry geometry = new GeometricForm(request.Name, height, width);

            var response = new GetGeometricFormResponse(
                geometry.Name.ToString(),
                geometry.Height,
                geometry.Width,
                geometry.Multiply(value));

            return response;
        }
    }
}
