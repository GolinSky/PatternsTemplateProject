using System.Collections.Generic;
using UnityEngine;

namespace GofPatterns.Patterns.Behavioral
{
    public interface IMemento<TState>
    {
        TState GetState();

        string GetId();
        //add some id(date or name)
    }

    public interface IOriginator<TState>
    {
        IMemento<TState> Save();
        void Restore(IMemento<TState> memento);
    }

    
    //it's more like example than abstraction 
    public abstract class Caretaker<TState>
      //  where TOriginator : IOriginator<TState>
//        where TMemento : IMemento<TState>
    {
        private readonly Stack<IMemento<TState>> mementoStack;

        private readonly IOriginator<TState> originator;

        protected Caretaker(IOriginator<TState> originator)
        {
            this.originator = originator;
            mementoStack = new Stack<IMemento<TState>>();
        }
        
        public virtual void Backup()
        {
            mementoStack.Push(originator.Save());
        }

        public virtual void Undo()
        {
            if (mementoStack.Count == 0)
            {
                return;
            }

            var memento = mementoStack.Pop();
            originator.Restore(memento);
        }

        public virtual void ShowHistory()
        {
            foreach (var memento in mementoStack)
            {
               Debug.Log(memento.GetId());
            }
        }
    }
}