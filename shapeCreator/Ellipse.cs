using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shapeCreator
{
    class Ellipse:Shape
    {

        private int horizontalDiameter;
		private int verticalDiameter;
		
		/*public Ellipse(int horizontalDiameter, int verticalDiameter){
			this.horizontalDiameter = horizontalDiameter;
			this.verticalDiameter = verticalDiameter; 
		}

        public Ellipse() { }*/
		
		public int HorizontalDiameter{
			get{
				return horizontalDiameter; 
			}
			set{
				this.horizontalDiameter=value; 
			}
		}
		
		public int VerticalDiameter{
			get{
				return verticalDiameter; 
			}
			set{
				this.verticalDiameter=value; 
			}
		}

        public override string getSizeShape()
        {
            return "diameterH = " + this.horizontalDiameter.ToString() + " " + "diameterV = " + this.verticalDiameter.ToString(); 
        }

        public override string getType()
        {
            return "Ellipse:";
        }


        public override void setParameters(Dictionary<string, string> listOfParams)
        {
            this.X = int.Parse(listOfParams["x"]);
            this.Y = int.Parse(listOfParams["y"]);
            this.horizontalDiameter = int.Parse(listOfParams["diameterH"]);
            this.verticalDiameter = int.Parse(listOfParams["diameterV"]);
        }
    }
}
