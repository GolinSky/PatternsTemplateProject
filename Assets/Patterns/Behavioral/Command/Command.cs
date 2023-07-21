namespace GofPatterns.Patterns.Behavioral.Command
{
    public abstract class Command:ICommand
    {
        protected IReceiver Receiver { get; }

        protected Command(IReceiver receiver)
        {
            Receiver = receiver;
        }

        public virtual void Execute()
        {
            Receiver.Action();
        }
    }
}