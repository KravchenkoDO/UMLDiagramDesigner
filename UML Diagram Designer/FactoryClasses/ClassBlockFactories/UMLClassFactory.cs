using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_Designer.UMLClasses;

namespace UML_Diagram_Designer.FactoryClasses.ClassBlockFactories
{
    public class UMLClassFactory : AbstractDiagramElementFactory
    {
        public override AbstractDiagramElement GetElement()
        {
            return new UMLClass();
        }
    }
}
