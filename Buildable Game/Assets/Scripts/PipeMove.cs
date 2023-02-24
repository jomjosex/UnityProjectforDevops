using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5;
    [SerializeField] private float _deadZone = -45;

    void Update()
    {
        transform.position += (Vector3.left * _moveSpeed) * Time.deltaTime;

        if (transform.position.x < _deadZone)
        {
            Destroy(gameObject);
        }
    }
}

