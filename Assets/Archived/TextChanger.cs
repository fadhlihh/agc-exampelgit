using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextChanger : MonoBehaviour
{
    // Mereferensikan object text mesh pro
    [SerializeField]
    private TMP_Text _exampleText;

    // Start is called before the first frame update
    void Start()
    {
        _exampleText.text = "Fadhli";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
