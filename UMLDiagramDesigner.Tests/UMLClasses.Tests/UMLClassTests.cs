using System.Collections;
using NUnit.Framework;
using UML_Diagram_Designer.UMLClasses;
using System.Drawing;

namespace UML_Diagram_Designer.Tests.UMLClasses.Tests
{
    public class UMLClassTests
    {
        [TestCaseSource(typeof(CheckIfTheObjectIsClicked))]
        public void CheckIfTheObjectIsClicked_WhenPointNotNull_ShouldReturnBool(UMLClass rectangle, Point point, bool expected)
        {
            bool actual = rectangle.CheckIfTheObjectIsClicked(point);
            Assert.AreEqual(expected, actual);
        }

        public class CheckIfTheObjectIsClicked : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] {
                   new UMLClass(Color.Black,8){startPointRect1= new Point(10,50),rect1Height=20,rect1Width=40 },
                   new Point(20,60),
                   true
                };

                yield return new object[] {
                   new UMLClass(Color.Black,8){startPointRect2= new Point(10,70),rect2Height=20,rect2Width=40 },
                   new Point(25,80),
                   true
                };

                yield return new object[] {
                   new UMLClass(Color.Black,8){startPointRect3= new Point(10,90),rect3Height=20,rect3Width=40 },
                   new Point(30,100),
                   true
                };
            }
        }
    }
}
