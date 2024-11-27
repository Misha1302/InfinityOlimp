using UnityEngine;

namespace Sharp
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Movement : MonoBehaviour
    {
        [SerializeField] private Vector2 speed = new(3f, 0f);

        private Rigidbody2D _rb;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            var axes = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            var movement = axes * speed;
            // movement.x = Mathf.Clamp(movement.x, -speed.x, speed.x);
            // movement.y = Mathf.Clamp(movement.y, -speed.y, speed.y);
            _rb.linearVelocity = movement;
        }
    }
}