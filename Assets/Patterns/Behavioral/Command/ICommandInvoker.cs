namespace GofPatterns.Patterns.Behavioral.Command
{
    public interface ICommandInvoker
    {
        void SetCommand(ICommand command);
        void ExecuteCommand();
    }
}