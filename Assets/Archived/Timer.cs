using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // [SerializeField]
    // private GameObject _cubeObject;
    // [SerializeField]
    // private Transform _spawnPosition;
    private float _timer = 5;
    private bool _isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Counter());
        // StartCoroutine(CounterSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        // if (_timer > 0)
        // {
        //     _timer = _timer - 1 * Time.deltaTime;
        //     Debug.Log(_timer.ToString("0"));
        // }
    }

    private IEnumerator Counter()
    {
        while (_isGameOver == false)
        {
            yield return new WaitForSeconds(1);
            _timer = _timer - 1;
            Debug.Log(_timer);
            // Instantiate(_cubeObject, _spawnPosition.position, _spawnPosition.rotation);
        }
    }

    // private IEnumerator CounterSpawner()
    // {
    //     // while (_isGameOver == false)
    //     // {
    //     //     yield return new WaitForSeconds(5);
    //     //     Instantiate(_cubeObject, _spawnPosition.position, _spawnPosition.rotation);
    //     }
    // }
}
