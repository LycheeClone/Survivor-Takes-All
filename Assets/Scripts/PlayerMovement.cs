using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 _movement;
    [SerializeField] private float speed;
    private Rigidbody _playerRb;

    private void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MoveThePlayer();
    }

    private void MoveThePlayer()
    {
        var x = Input.GetAxis("Horizontal") * (speed * Time.deltaTime);
        var z = Input.GetAxis("Vertical") * (speed * Time.deltaTime);
        _movement = new Vector3(x, 0f, z);
        _playerRb.AddForce(_movement, ForceMode.VelocityChange);
        //transform.position += _movement;
    }
    

    // private void OnCollisionEnter(Collision col)
    // {
    //     
    //     //GetComponent<MeshRenderer>().material.color = Color.red;
    //     
    //     if (col.gameObject.CompareTag("Obstacle"))
    //     {
    //         //Method 1
    //         // var mesh = col.gameObject.GetComponent<MeshRenderer>();
    //         // mesh.material.SetColor("_Color", Color.red);
    //         //Method 2
    //         //col.gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);
    //         //Method 3
    //         col.gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
    //     }
    // }
}