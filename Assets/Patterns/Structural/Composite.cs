using System.Collections.Generic;

namespace GofPatterns.Patterns.Structural
{

    public interface IComponent
    {
        void Execute();
    }


    public interface IComposite<TComponent>
    {
        void Add(TComponent component);
        void Remove(TComponent component);
        
    }

    public abstract class Composite<TComponent> :IComposite<TComponent>, IComponent
        where TComponent:IComponent
    {
        protected abstract IEnumerable<TComponent> Components { get; }


        public abstract void Add(TComponent component);

        public abstract void Remove(TComponent component);
 
        public void Execute()
        {
            foreach (var component in Components)
            {
                component.Execute();
            }
        }
    }

    // public class ComponentImpl : IComponent
    // {
    //     public void Execute()
    //     {
    //         
    //     }
    // }
    //
    // public class CompositeImpl:Composite<ComponentImpl>
    // {
    //     protected override IEnumerable<ComponentImpl> Components => componentImpls;
    //
    //     private List<ComponentImpl> componentImpls = new List<ComponentImpl>();
    //
    //     public override void Add(ComponentImpl component)
    //     {
    //         componentImpls.Add(component);
    //     }
    //
    //     public override void Remove(ComponentImpl component)
    //     {
    //         componentImpls.Remove(component);
    //     }
    // }
}