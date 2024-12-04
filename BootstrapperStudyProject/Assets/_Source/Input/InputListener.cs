using ClickerSystem;
using UnityEngine;

namespace Core
{
    public class InputListener : MonoBehaviour
    {
        private Game _game;
        private ClickListener _clickListener;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                OnExitInput();
            }

            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                OnLMBInput();
            }
        }

        public void Setup(Game game, ClickListener clickListener)
        {
            _game = game;
            _clickListener = clickListener;
        }

        private void OnExitInput()
        {
            _game?.ExitGame();
        }

        private void OnLMBInput()
        {
            _clickListener.Click(Input.mousePosition);
        }
    }
}