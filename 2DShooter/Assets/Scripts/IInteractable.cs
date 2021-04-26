namespace Shooter
{
    public interface IInteractable : IAction, IInitialization
    {
        bool IsInteractable { get; }
    }
}
