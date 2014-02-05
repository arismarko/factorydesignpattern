using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shapeCreator
{
    class Circle:Shape
    {
        private int size;
        
        /*
        public Circle(int size)
        {
			this.size = size;
		}

        public Circle(){}
		*/

		public int Size{
			get{
				return size;
			}
			set{
				this.size = value;
			}
		}

        public override string getSizeShape()
        {
            return  "size=" + this.size.ToString(); 
        }

        public override string getType()
        {
            return "Circle"; 
        }


        public override void setParameters(Dictionary<string, string> listOfParams)
        {
            this.X = int.Parse(listOfParams["x"]);
            this.Y = int.Parse(listOfParams["y"]);
            this.size = int.Parse(listOfParams["size"]);
        }
    }
}
