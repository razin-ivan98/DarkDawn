using UnityEngine;
using UnityEngine.Events;

namespace Code
{
    public class InputService
    {
        private const int MouseLeftButtonNumber = 0;
        private const string Horizontal = "Horizontal";

        public UnityAction Attacked;
        public UnityAction<float> Moved;

        public void UpdateInputs()
        {
            float movement = GetMovement();
            if (movement != 0)
            {
                Moved.Invoke(movement);
            }

            if (GetAttacked())
            {
                Attacked.Invoke();
            }
        }
        
        private float GetMovement()
        {
            return Input.GetAxis(Horizontal);
        }

        private bool GetAttacked()
        {
            return Input.GetMouseButtonDown(MouseLeftButtonNumber);
        }
    }
}
