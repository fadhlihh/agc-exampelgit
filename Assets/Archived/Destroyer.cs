using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField]
    private GameObject _cubeObject;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(_cubeObject);
    }
}
