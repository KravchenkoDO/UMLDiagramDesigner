using UML_Diagram_Designer.FactoryClasses;
using UML_Diagram_Designer.FactoryClasses.RelationshipFactories;

namespace UML_Diagram_Designer
{
    public class FactoryChanger
    {
        string factoryName;
        AbstractDiagramElementFactory editFactory;

        public FactoryChanger(string factory)
        {
            factoryName = factory;
        }

        public AbstractDiagramElementFactory GetEditFactory()
        {
            switch (factoryName)
            {
                case "Association":
                    editFactory = new AssociationRelationshipFactory();
                    break;
                case "Inheritance":
                    editFactory = new InheritanceRelationshipFactory();
                    break;
                case "Realization":
                    editFactory = new RealizationRelationshipFactory();
                    break;
                case "Composition":
                    editFactory = new CompositionRelationshipFactory();
                    break;
                case "Aggregation":
                    editFactory = new AggregationRelationshipFactory();
                    break;
            }

            return editFactory;
        }
    }
}
