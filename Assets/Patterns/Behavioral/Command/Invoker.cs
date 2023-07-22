namespace GofPatterns.Patterns.Behavioral
{
    public abstract class Invoker:ICommandInvoker
    {
        protected ICommand Command { get; private set; }
        
        void ICommandInvoker.SetCommand(ICommand command)
        {
            Command = command;
        }
        void ICommandInvoker.ExecuteCommand()
        {
            Command.Execute();
        }
    }
}