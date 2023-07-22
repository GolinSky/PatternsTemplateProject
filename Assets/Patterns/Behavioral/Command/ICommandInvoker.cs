namespace GofPatterns.Patterns.Behavioral
{
    public interface ICommandInvoker
    {
        void SetCommand(ICommand command);
        void ExecuteCommand();
    }
}