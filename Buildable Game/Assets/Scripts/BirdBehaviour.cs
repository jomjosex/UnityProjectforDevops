using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehaviour : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _myRigidbody;
    [SerializeField] private float _flapStrength;
    public GameLogic Logic;
    private bool _isAlive = true;

    void Awake()
    {
        if (Logic == null)
        {
            Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>();
        }
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isAlive)
        {
            _myRigidbody.velocity = Vector2.up * _flapStrength;
        }

        if (transform.position.y < -20)
        {
            KillBird();
        }

        if (transform.position.y > 20)
        {
            KillBird();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        KillBird();
    }

    private void KillBird()
    {
        Logic.GameOver();
        _isAlive = false;
    }
}
