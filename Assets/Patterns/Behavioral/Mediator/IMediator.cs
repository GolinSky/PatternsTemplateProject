using System.Collections.Generic;

namespace GofPatterns.Patterns.Behavioral
{
    public interface IMediator<TSender>
    {
        void AddSender(TSender user);
    }
    
    //todo: rebuild this 
    public interface IMediator<TMessage, TSender>:IMediator<TSender>
    {
       void SendMessage(TMessage msg, TSender user);
    }

    // public abstract class Mediator<TMessage, TSender>:IMediator<TMessage, TSender>
    // {
    //     private IEnumerable<TSender> senders;
    //     
    //     public abstract void AddSender(TSender user);
    //
    //     public void SendMessage(TMessage msg, TSender user)
    //     {
    //         foreach (var sender in senders)
    //         {
    //             if (sender != user)
    //             {
    //                 sender.Receive();
    //             }
    //         }
    //     }
    // }
}