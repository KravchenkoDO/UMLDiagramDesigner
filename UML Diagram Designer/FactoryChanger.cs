using UML_Diagram_Designer.FactoryClasses;
using UML_Diagram_Designer.FactoryClasses.RelationshipFactories;

namespace UML_Diagram_Designer
{
    public class FactoryChanger
    {
        string _factoryName;
        AbstractDiagramElementFactory _editFactory;

        public FactoryChanger(string factory)
        {
            _factoryName = factory;
        }

        public AbstractDiagramElementFactory GetEditFactory()
        {
            switch (_factoryName)
            {
                case "Association":
                    _editFactory = new AssociationRelationshipFactory();
                    break;
                case "Inheritance":
                    _editFactory = new InheritanceRelationshipFactory();
                    break;
                case "Realization":
                    _editFactory = new RealizationRelationshipFactory();
                    break;
                case "Composition":
                    _editFactory = new CompositionRelationshipFactory();
                    break;
                case "Aggregation":
                    _editFactory = new AggregationRelationshipFactory();
                    break;
            }

            return _editFactory;
        }
    }
}
