using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_Designer.Relationships;

namespace UML_Diagram_Designer.FactoryClasses.RelationshipFactories
{
    class AggregationRelationshipFactory : AbstractRelationshipFactory
    {
        public override AbstractRelationship GetRelationship(AbstractLine abstractLine, AbstractCap abstractCap)
        {
            throw new NotImplementedException();
        }
    }
}
