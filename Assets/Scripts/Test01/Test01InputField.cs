using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Test01InputField : MonoBehaviour
{

    private TMP_InputField input;
    void Start()
    {
        this.input = this.GetComponentInChildren<TMP_InputField>();
        this.input.onValueChanged.AddListener((str) =>
        {
            Debug.Log(str);
        });
    }

    
}
