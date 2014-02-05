using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace shapeCreator
{
    abstract class Shape : IShape
    {
        private int x = 0;
        private int y = 0;

        public abstract String getSizeShape();
        public abstract String getType();
        public abstract void setParameters(Dictionary<String, String> listOfParams); 

       //public abstract String getDetails();

        public Shape() { }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                this.y = value;
            }
        }


        public String getLocation()
        {
            return "(" + this.x + "," + this.y + ")"; 
        }


        public string getDetails()
        {
            return getType() + " " + getLocation() + " " + getSizeShape();
        }

    }
}
