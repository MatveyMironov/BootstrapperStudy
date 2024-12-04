using UnityEngine;

namespace ClickerSystem
{
    public class ClickListener : MonoBehaviour
    {
        [SerializeField] private GameObject objectToClick;
        [SerializeField] private int rewardPoints;
        [SerializeField] private GameObject objectToNotClick;
        [SerializeField] private int penaltyPoints;

        private Camera _mainCamera;

        private Score _score;

        private void Awake()
        {
            _mainCamera = Camera.main;
        }

        public void Setup(Score score)
        {
            _score = score;
        }

        public void Click(Vector3 mousePosition)
        {
            Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit raycastHit, 100f))
                if (raycastHit.transform != null)
                    CompareGameObject(raycastHit.transform.gameObject);
        }

        private void CompareGameObject(GameObject gameObject)
        {
            if (gameObject == objectToClick)
                RegisterPoints(rewardPoints);
            else if (gameObject == objectToNotClick)
                RegisterPoints(-penaltyPoints);
        }

        private void RegisterPoints(int points)
        {
            if (_score != null)
                _score.Points += points;
        }
    }
}