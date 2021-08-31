using Game.Enums;


namespace Game.CharacterStates
{
    public abstract class EntityState
    {
        private int _stateIdentifier;
        public int StateIdentifier
        {
            get { return _stateIdentifier; }
            set { _stateIdentifier = value; }
        }
    }
}