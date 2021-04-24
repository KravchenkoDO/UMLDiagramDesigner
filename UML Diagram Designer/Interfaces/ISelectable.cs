using System.Drawing;

namespace UML_Diagram_Designer.Interfaces
{
    public interface ISelectable
    {
        bool CheckIfTheObjectIsClicked(Point point);
    }
}
