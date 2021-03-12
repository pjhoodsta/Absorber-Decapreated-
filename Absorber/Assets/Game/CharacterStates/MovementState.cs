using Game.Enums;
namespace Game.CharacterStates
{
    public class MovementState : EntityState
    {
        private int _movementStateIdentifier;
        public int MovementStateIdentifier {
            get { return _movementStateIdentifier; }
            set { _movementStateIdentifier = value; }
        }
        public MovementState(int optionalMovementIdentifier = 0)
        {
            StateIdentifier = EntityStates.Movement;
            _movementStateIdentifier = optionalMovementIdentifier;
        }

    }
}