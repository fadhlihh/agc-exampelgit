using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _vfxAnimal;
    [SerializeField]
    private Transform _cube;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_vfxAnimal, _cube.position, _cube.rotation);
        }
    }
}
