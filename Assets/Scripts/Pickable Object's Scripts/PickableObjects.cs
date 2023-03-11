using UnityEngine;

namespace Pickable_Object_s_Scripts
{
    public class PickableObjects : MonoBehaviour
    {
        [SerializeField] private int increaseAmount = 1;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                ScoreManager callScoreManager = FindObjectOfType<ScoreManager>();
                callScoreManager.score += increaseAmount;
                print(callScoreManager.score);
                Destroy(gameObject);
            }
        }

        private void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.CompareTag("Player"))
            {
                ScoreManager callScoreManager = FindObjectOfType<ScoreManager>();
                callScoreManager.score += increaseAmount;
                print(callScoreManager.score);
                Destroy(gameObject);
            } 
        }
    }
}