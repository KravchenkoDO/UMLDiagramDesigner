using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.FactoryClasses
{
   public abstract class AbstractDiagramElementFactory
    {
        public abstract AbstractDiagramElement GetElement(Color lineColor, float lineWidth);
    }
}
