using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private Transform _cubeTransform;
    [SerializeField]
    private Rigidbody _cubeRigidbody;
    private void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalAxis, 0, verticalAxis);
        // _cubeTransform.position = _cubeTransform.position + movementDirection * _speed * Time.deltaTime;
        // _cubeTransform.Translate(movementDirection * _speed * Time.deltaTime);
        _cubeRigidbody.AddForce(movementDirection * _speed * Time.deltaTime);
    }
}
