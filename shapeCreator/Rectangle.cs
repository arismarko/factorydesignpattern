using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shapeCreator
{
    class Rectangle:Shape
    {
        private int width;
        private int height;

        public Rectangle(int width, int height){
			this.width = width;
			this.height= height; 
		}

        public Rectangle(){}
		
		public int Width{
			get{
				return width; 
			}
			set{
				this.width=value; 
			}
		}
		
		public int Height{
			get{
				return height; 
			}
			set{
				this.height=value; 
			}
		}

        public override string getSizeShape()
        {
            return "width=" + this.width.ToString() + " height=" + this.height.ToString();
        }

        public override string getType()
        {
            return "Rectangle";
        }




        public override void setParameters(Dictionary<string, string> listOfParams)
        {
            this.X = int.Parse(listOfParams["x"]);
            this.Y = int.Parse(listOfParams["y"]);
            this.Width = int.Parse(listOfParams["width"]);
            this.Height = int.Parse(listOfParams["height"]);
        }
    }

}

