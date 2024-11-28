namespace Sharp
{
    public interface IMovement
    {
        public void Enter(PlayerMovementManager movementManager);
        public void Exit(PlayerMovementManager movementManager);
        public void Move(PlayerMovementManager movementManager);
    }
}