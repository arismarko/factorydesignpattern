using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shapeCreator
{
    class Square:Shape
    {
        private int size;

       /* public Square(int size)
        {
            this.size = size;
        }

        public Square() { }
        */

        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                this.size = value;
            }
        }


        public override string getSizeShape()
        {
            return "size=" + this.size.ToString();
        }

        public override string getType()
        {
            return "Square";
        }


        public override void setParameters(Dictionary<string, string> listOfParams)
        {
            this.X = int.Parse(listOfParams["x"]);
            this.Y = int.Parse(listOfParams["y"]);
            this.Size = int.Parse(listOfParams["size"]);
        }
    }
}
