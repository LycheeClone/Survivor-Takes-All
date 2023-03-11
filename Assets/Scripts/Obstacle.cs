using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private int decreaseAmount = -1;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            var scoreManager = FindObjectOfType<ScoreManager>();
            //Yol 1 scoreManager.score--;
            scoreManager.score += decreaseAmount;
            print(scoreManager.score);
            //Color Switch Method 2
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
// Calling Another Script Method 1
// ScoreManager1 scoreManager = FindObjectOfType<ScoreManager1>();
// scoreManager.score -= 5;
// print(FindObjectOfType<ScoreManager1>().score);

//Color Switch Method 1
// var mesh = col.gameObject.GetComponent<MeshRenderer>();
// mesh.material.SetColor("_Color", Color.red);
//Method 2
//col.gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);
//Method 3
//GetComponent<MeshRenderer>().material.color = Color.black;