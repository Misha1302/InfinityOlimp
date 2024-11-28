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
            movementManager.Rb.velocity = movementManager.Rb.velocity.WithX(movementManager.Speed.x);
            if (movementManager.IsJumping)
                movementManager.Rb.velocity = movementManager.Rb.velocity.WithY(movementManager.jumpSpeed);
        }
    }
}