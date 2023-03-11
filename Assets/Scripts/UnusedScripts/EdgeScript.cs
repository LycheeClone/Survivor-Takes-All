// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class EdgeScript : MonoBehaviour
// {
//
//     private void OnCollisionEnter(Collision collision)
//     {
//         if (collision.gameObject.CompareTag("Player"))
//         {
//             var skortutucu = FindObjectOfType<ScoreManager>();
//             float otherScore = skortutucu.score *= 2;
//             Debug.Log("Skorunuz = " + otherScore);
//             gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
//             //print(skortutucu.scoreMultiplier *= 2);
//
//         }
//     }
// }
