using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace shapeCreator
{
    interface IShape
    {
         String getType();
         String getLocation();
         String getSizeShape();
         String getDetails();
         void setParameters(Dictionary<String, String> listOfParams); 
    }
}
