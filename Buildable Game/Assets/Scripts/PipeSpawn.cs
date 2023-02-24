using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _pipe;
    [SerializeField] private float _spawnRate = 2;
    private float _timer = 0;
    [SerializeField] private float _heightOffset = 10;

    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        if (_timer < _spawnRate)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            _timer = 0;
        }

    }

    private void SpawnPipe()
    {
        var lowestPoint = transform.position.y - _heightOffset;
        var highestPoint = transform.position.y + _heightOffset;

        Instantiate(_pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
