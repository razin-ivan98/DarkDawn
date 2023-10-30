using Code.Player;
using UnityEngine;

namespace Code
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private PlayerFasade playerPrefab;
        [SerializeField] private Transform spawnPoint;
        private readonly InputService _inputService = new InputService();

        public void Start()
        {
            PlayerFasade player = Instantiate(playerPrefab, spawnPoint);
            player.Init(_inputService);
        }

        public void Update()
        {
            _inputService.UpdateInputs();
        }
    }
}
