namespace Game.CharacterStates
{
    public interface IStateHandler<T>
    {
        bool CanHandle(T data);
        void Handle(T data);
    }
}