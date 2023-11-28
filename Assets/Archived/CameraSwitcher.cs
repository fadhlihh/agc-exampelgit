using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField]
    private GameObject _mainCamera;
    [SerializeField]
    private GameObject _camera1;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCamera();
        }
    }

    private void SwitchCamera()
    {
        if (_mainCamera.activeInHierarchy)
        {
            _mainCamera.SetActive(false);
            _camera1.SetActive(true);
        }
        else
        {
            _camera1.SetActive(false);
            _mainCamera.SetActive(true);
        }
    }
}
