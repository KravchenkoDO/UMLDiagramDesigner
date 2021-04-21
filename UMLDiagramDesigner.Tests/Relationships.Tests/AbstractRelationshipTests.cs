using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using NUnit.Framework;
using UML_Diagram_Designer.Relationships;
using System.Drawing;


namespace UML_Diagram_Designer.Tests.Relationships.Tests
{
    public class AbstractRelationshipTests
    {
    [TestCaseSource(typeof(CheckIfTheObjectIsClicked))]
        public void CheckIfTheObjectIsClicked_WhenPointNotNull_ShouldReturnBool(AggregationRelationship aggregation, Point point, bool expected)
        {
            bool actual = aggregation.CheckIfTheObjectIsClicked(point);
            Assert.AreEqual(expected, actual);
        }

        public class CheckIfTheObjectIsClicked : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
               yield return new object[] { 
                   new AggregationRelationship(Color.Red, 8) { EndPoint=new Point(0,0),StartPoint= new Point(50,60)},
                   new Point(0,1),
                   true
                };

                yield return new object[] {
                   new AggregationRelationship(Color.Red, 8) { EndPoint=new Point(0,0),StartPoint= new Point(50,30)},
                   new Point(1,0),
                   true
                };

                yield return new object[] {
                   new AggregationRelationship(Color.Red, 8) { EndPoint=new Point(0,0),StartPoint= new Point(50,60)},
                   new Point(0,2),
                   true
                };
            }
        }
    }
}
