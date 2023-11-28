using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXPlayer : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem _vfxAnimal;
    void Update()
    {
        //Deteksi Input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Play vfx
            _vfxAnimal.Play();
        }
    }
}
