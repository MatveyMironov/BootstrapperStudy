using ClickerSystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private Game game;
        [SerializeField] private InputListener inputListener;
        [SerializeField] private ClickListener clickListener;
        [SerializeField] private ScoreUI scoreUI;

        private void Awake()
        {
            Score score = new();

            inputListener.Setup(game, clickListener);
            game.Setup(score);
            clickListener.Setup(score);
            scoreUI.Setup(score);
        }
    }
}