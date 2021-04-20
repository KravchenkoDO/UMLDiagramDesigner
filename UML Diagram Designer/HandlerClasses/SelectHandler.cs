//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using UML_Diagram_Designer.FactoryClasses;

//namespace UML_Diagram_Designer.HandlerClasses
//{
//    class SelectHandler : AbstractHandler
//    {
//        public Canvas canvas = Canvas.GetCanvas();
//        public AbstractDiagramElement _currentDiagramElement;
//        public SelectHandler(AbstractDiagramElementFactory diagramFactory)
//        {
//            _currentDiagramElement = diagramFactory.GetElement(canvas.PenColor, canvas.PenSize);
//        }

//        public void MouseClick(Point point)
//        {
//            throw new NotImplementedException();
//        }

//        public void MouseDown(Point point)
//        {
//            foreach (var element in canvas.listAbstractDiagramElements)
//            {
//                if (element.CheckIfTheObjectIsClicked(point))
//                {
//                    _currentDiagramElement = element;
//                    break;
//                }
//            }
//        }

//        public void MouseMove(Point point)
//        {
//            throw new NotImplementedException();
//        }

//        public void MouseUp(Point point)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
