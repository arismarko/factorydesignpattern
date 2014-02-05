using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shapeCreator
{
    class TextBoxRectangle : Rectangle
    {
        private String text;

        public String Text
        {
            get
            {
                return text;
            }
            set
            {
                this.text = value;
            }
        }

        public override string getType()
        {
            return "Textbox:";
        }

        public override string getSizeShape()
        {
            return "width=" + this.Width.ToString() + " height=" + this.Height.ToString() + " Text='" + this.text + "'";
        }

        public override void setParameters(Dictionary<string, string> listOfParams)
        {
            this.X = int.Parse(listOfParams["x"]);
            this.Y = int.Parse(listOfParams["y"]);
            this.Width = int.Parse(listOfParams["width"]);
            this.Height = int.Parse(listOfParams["height"]);
            this.Text = listOfParams["text"];
        }

        
    }


}
