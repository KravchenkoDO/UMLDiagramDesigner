using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_Designer.UMLClasses
{
    public class AbstractUMLClass : AbstractDiagramElement
    {
        public EnumSections select;

        public override bool CheckIfTheObjectIsClicked(Point point)
        {
            throw new NotImplementedException();
        }

        public override void Draw(Canvas painter)
        {
            throw new NotImplementedException();
        }

        public override void Move(int deltaX, int deltaY)
        {
            throw new NotImplementedException();
        }

        public override void SaveElementText(string strText)
        {
            throw new NotImplementedException();
        }
}
}
