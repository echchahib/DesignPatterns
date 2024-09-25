using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class ShapeFactory
    {

        public IShape CreateShape(string ShapeName)
        {
            if(ShapeName == null)
                throw new ArgumentNullException("No shape exist to create !");
            if (ShapeName.Equals("Circle", StringComparison.OrdinalIgnoreCase))
                return new Circle();
            else if (ShapeName.Equals("Triangle", StringComparison.OrdinalIgnoreCase))
                return new Triangle();
            else if (ShapeName.Equals("Square", StringComparison.OrdinalIgnoreCase))
                return new Square();
            else
                throw new ArgumentException("No shape exist to create !");
        }
    }
}
