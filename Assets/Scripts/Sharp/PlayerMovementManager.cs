using UnityEngine;

namespace Sharp
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovementManager : MonoBehaviour
    {
        [SerializeField] private Vector2 speed = new(3f, 0f);
        [SerializeField] private MonoBehaviour defaultMovement;
        [SerializeField] public float jumpSpeed = 10f;

        private IMovement _currentMovement;

        public Rigidbody2D Rb { get; private set; }

        public Vector2 Speed => new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;
        public bool IsJumping => Input.GetButtonDown("Jump");

        private void Start()
        {
            Rb = GetComponent<Rigidbody2D>();
            ChangeMovement(defaultMovement as IMovement);
        }

        private void Update()
        {
            _currentMovement.Move(this);
        }

        private void ChangeMovement(IMovement movement)
        {
            _currentMovement?.Exit(this);
            _currentMovement = movement;
            _currentMovement?.Enter(this);
        }
    }
}