using Game.Enums;
namespace Game.CharacterStates
{
    public class IdleState : EntityState
    {
        private int _idleStateIdentifier;
        public int IdleStateIdentifier
        {
            get { return _idleStateIdentifier; }
            set { _idleStateIdentifier = value; }
        }
        public IdleState(int optionalMovementIdentifier = 0)
        {
            StateIdentifier = EntityStates.Idle;
            _idleStateIdentifier = optionalMovementIdentifier;
        }

    }
}