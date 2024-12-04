using System;
using UnityEngine;

namespace ClickerSystem
{
    public class Score
    {
        private int _points;

        public int Points { get { return _points; } set { SetPoints(value); } }

        public event Action OnScoreChanged;

        private void SetPoints(int value)
        {
            _points = value;
            OnScoreChanged?.Invoke();
        }
    }
}