using UnityEngine;

namespace Level_Control_Scripts
{
    public class TimeManager : MonoBehaviour
    {
        [SerializeField] private float levelStart;
        [SerializeField] private float levelEnd;
        private bool _isFinished;
        public bool gameOver;

        private void FixedUpdate()
        {
            TimeCountToFinish();
        }

        void TimeCountToFinish()
        {
            if (Time.time is > 0f and <= 3f)
            {
                //print(Time.time);
            }
            else if (Time.time >= levelStart && Time.time <= levelEnd)
            {
                _isFinished = true;
                //print(Time.time + " . Saniyeye geldin");
            }
        }
    }
}