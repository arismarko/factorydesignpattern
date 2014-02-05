using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace shapeCreator
{
    class InitProgram
    {
        static void Main(string[] args)
        {

           Dictionary<ShapeFactory.ShapeType, IShape> shapes = new Dictionary<ShapeFactory.ShapeType, IShape>();

            IShape newCircle =  ShapeFactory.CreateShape(ShapeFactory.ShapeType.CircleType);

            newCircle.setParameters(new Dictionary<String, String>() { { "x", "1" }, { "y", "1" }, { "size", "300" } });

            IShape newSquare = (Square)ShapeFactory.CreateShape(ShapeFactory.ShapeType.SquareType);
            
            newSquare.setParameters(new Dictionary<String,String>(){ {"x","15"},{"y","30"}, {"size", "35"}});

            IShape newRectangle = (Rectangle)ShapeFactory.CreateShape(ShapeFactory.ShapeType.RectangleType);

            newRectangle.setParameters(new Dictionary<String, String>() { { "x", "10" }, { "y", "10" }, { "width", "30" }, { "height", "40" } });

            IShape newEllipse = (Ellipse)ShapeFactory.CreateShape(ShapeFactory.ShapeType.EllipseType);

            newEllipse.setParameters(new Dictionary<String, String>() { { "x", "100" }, { "y", "150" }, { "diameterH", "300" }, { "diameterV", "200" } });

            IShape newTextBoxRectangle = (TextBoxRectangle)ShapeFactory.CreateShape(ShapeFactory.ShapeType.TextBoxRectangleType);

            newTextBoxRectangle.setParameters(new Dictionary<String, String>() { { "x", "5" }, { "y", "5" }, { "width", "200" }, { "height", "100" }, { "text", "sample text" }  });
            shapes.Add(ShapeFactory.ShapeType.RectangleType, newRectangle);
            shapes.Add(ShapeFactory.ShapeType.SquareType, newSquare);
            shapes.Add(ShapeFactory.ShapeType.EllipseType, newEllipse);
            shapes.Add(ShapeFactory.ShapeType.CircleType, newCircle);
            shapes.Add(ShapeFactory.ShapeType.TextBoxRectangleType, newTextBoxRectangle);

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine(" Current Drawing ");
            Console.WriteLine("-----------------------------------------------------------------");
            foreach (IShape shape in shapes.Values){
                Console.WriteLine(shape.getDetails()); 
            }
            Console.WriteLine("-----------------------------------------------------------------");

        }
    }
}
