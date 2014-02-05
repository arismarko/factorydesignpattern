using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shapeCreator
{
    class ShapeFactory
    {
        public enum ShapeType
        {
            CircleType,
            EllipseType,
            RectangleType,
            SquareType,
            TextBoxRectangleType
        }

        public static IShape CreateShape(ShapeType type)
        {
            IShape shape = null;
            switch (type)
            {
                case ShapeType.CircleType:
                    shape = new Circle();
                    break;
                case ShapeType.EllipseType:
                    shape = new Ellipse();
                    break;
                case ShapeType.RectangleType:
                    shape = new Rectangle();
                    break;
                case ShapeType.SquareType:
                    shape = new Square();
                    break;
                case ShapeType.TextBoxRectangleType:
                    shape = new TextBoxRectangle();
                    break;
                default:
                    throw new ArgumentException(string.Format("A Shape of type {0} cannot be found", Enum.GetName
                     (typeof(ShapeType), type)));
            }

            return shape;
        }
    }
}
