using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test02UIStart : MonoBehaviour
{
    [SerializeField]
    private Button startBtn;
    [SerializeField]
    private GameObject popupPrefab;
    void Start()
    {

        this.startBtn = this.GetComponentInChildren<Button>();
        this.startBtn.onClick.AddListener(() =>
        {
            Instantiate(popupPrefab);
        });

    }

}
