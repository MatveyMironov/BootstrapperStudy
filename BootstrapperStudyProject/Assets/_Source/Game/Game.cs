using ClickerSystem;
using UnityEngine;

namespace Core
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private int defaultScorePoints;

        private Score _score;

        public void Setup(Score score)
        {
            _score = score;
            _score.Points = defaultScorePoints;
        }

        public void ExitGame()
        {
            if (_score != null)
            {
                _score.Points = 0;

#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#endif
            }
        }
    }
}