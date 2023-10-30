using UnityEngine;

namespace Code.Player
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class PlayerMover : MonoBehaviour
    {
        private SpriteRenderer _spriteRenderer;
        [SerializeField] private float speed = 1;

        public void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        public void Move(float movement)
        {
            transform.position += new Vector3(movement * Time.deltaTime * speed, 0);
            if (movement != 0)
            {
                _spriteRenderer.flipX = movement < 0;
            }
        }
    }
}
