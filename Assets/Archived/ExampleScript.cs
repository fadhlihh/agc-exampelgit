using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    [SerializeField]
    private Transform _cubeTransform;


    // Start is called before the first frame update
    void Start()
    {
        // _cubeTransform.position = new Vector3(1, 1, 1);
        // _cubeTransform.rotation = Quaternion.Euler(45, 0, 0);
        _cubeTransform.localScale = new Vector3(5, 5, 5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
