using UnityEngine;

namespace Sharp
{
    public class PlatformPersonMovement : MonoBehaviour, IMovement
    {
        public void Enter(PlayerMovementManager movementManager)
        {
            movementManager.Rb.gravityScale = 1f;
        }

        public void Exit(PlayerMovementManager movementManager)
        {
        }

        public void Move(PlayerMovementManager movementManager)
        {
            movementManager.Rb.linearVelocity = movementManager.Rb.linearVelocity.WithX(movementManager.Speed.x);
            if (movementManager.IsJumping)
                movementManager.Rb.linearVelocity = movementManager.Rb.linearVelocity.WithY(movementManager.jumpSpeed);
        }
    }
}