using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _cubePrefabs;
    // [SerializeField]
    // private Transform _spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);
        Instantiate(_cubePrefabs, spawnPosition, Quaternion.Euler(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
