using System;
using System.Collections;
using System.Collections.Generic;
using Level_Control_Scripts;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if (gameObject.CompareTag("Player"))
        {
            FindObjectOfType<TimeManager>().gameOver = true;
        }

        if (col.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("Zemin Teması");
        }

        Destroy(col.gameObject);
    }
}