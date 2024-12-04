using TMPro;
using UnityEngine;

namespace ClickerSystem
{
    public class ScoreUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreText;

        private Score _score;

        public void Setup(Score score)
        {
            _score = score;
            _score.OnScoreChanged += DisplayScore;
            DisplayScore();
        }

        private void DisplayScore()
        {
            scoreText.text = _score.Points.ToString();
        }
    }
}