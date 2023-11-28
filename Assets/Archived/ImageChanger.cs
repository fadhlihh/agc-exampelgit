using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    // Siapkan field untuk akses object image
    [SerializeField]
    private Image _image;

    // Siapkan asset image yang ingin kita tampilkan di object image
    [SerializeField]
    private Sprite _spriteAsset;

    // Merubah gambar object image menjadi asset gambar agate academy saat game nya dimulai
    private void Start()
    {
        // Mengganti gambar object image
        _image.sprite = _spriteAsset;
    }
}
