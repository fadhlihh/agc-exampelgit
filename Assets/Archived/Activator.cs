using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    [SerializeField]
    private GameObject _cube;
    // Start is called before the first frame update
    void Start()
    {
        _cube.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
