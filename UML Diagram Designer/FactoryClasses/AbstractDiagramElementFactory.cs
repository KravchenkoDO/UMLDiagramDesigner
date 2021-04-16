using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.FactoryClasses
{
    abstract class AbstractDiagramElementFactory
    {
        public abstract AbstractDiagramElement GetElement();
    }
}
