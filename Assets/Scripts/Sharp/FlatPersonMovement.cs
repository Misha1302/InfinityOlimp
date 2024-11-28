using UnityEngine;

namespace Sharp
{
    public class FlatPersonMovement : MonoBehaviour, IMovement
    {
        public void Enter(PlayerMovementManager movementManager)
        {
            movementManager.Rb.gravityScale = 0f;
        }

        public void Exit(PlayerMovementManager movementManager)
        {
        }

        public void Move(PlayerMovementManager movementManager)
        {
            movementManager.Rb.velocity = movementManager.Speed;
        }
    }
}