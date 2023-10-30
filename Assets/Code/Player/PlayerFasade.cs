using UnityEngine;

namespace Code.Player
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(PlayerMover))]
    public class PlayerFasade : MonoBehaviour
    {
        private static readonly int AttackTrigger = Animator.StringToHash("attack");
        private static readonly int  IsRunning =  Animator.StringToHash("isRunning");
        
        private PlayerMover _playerMover;
        private InputService _inputService;
        private Animator _animator;

        public void Start()
        {
            _playerMover = GetComponent<PlayerMover>();
            _animator = GetComponent<Animator>();
        }
        public void Init(InputService inputService)
        {
            _inputService = inputService;
            _inputService.Attacked += Attack;
            _inputService.Moved += Move;
        }

        private void Attack()
        {
            _animator.SetTrigger(AttackTrigger);
        }

        private void Move(float movement)
        {
            _playerMover.Move(movement);
            _animator.SetBool(IsRunning, movement != 0);
        }
    }
}
