using System;
using System.Collections;
using System.Collections.Generic;
using Level_Control_Scripts;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class EnemyController : MonoBehaviour
{
    private Transform _target;
    [SerializeField] private float distance;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float stopDistance = 1.5f;

    private void Start()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            _target = GameObject.FindWithTag("Player").GetComponent<Transform>();
        }
    }

    private void Update()
    {
        TargetLook();
    }

    private void FixedUpdate()
    {
        if (_target != null)
        {
            DistanceCalc();
            EnemyStopControl();
        }
    }

    private void MoveTowardsPlayer()
    {
        var transform1 = transform;
        var position = transform1.position;
        position += transform1.forward * (moveSpeed * Time.deltaTime);
        transform1.position = position;
    }

    private void DistanceCalc()
    {
        distance = Vector3.Distance(transform.position, _target.position);
    }

    void TargetLook()
    {
        transform.LookAt(_target);
    }

    void EnemyStopControl()
    {
        if (distance > stopDistance)
        {
            MoveTowardsPlayer();
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (_target != null)
        {
            if (col.gameObject.CompareTag("Player"))
            {
                Destroy(col.gameObject);
                TimeManager timeManager = FindObjectOfType<TimeManager>();
                timeManager.gameOver = true;
                print(timeManager.gameOver);
            }
        }
    }
}