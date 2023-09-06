using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class Test02UIPopupName : MonoBehaviour
{
    
    private TMP_InputField inputField;

    [SerializeField]
    private Button abledBtn;
    [SerializeField]
    private Button disabledBtn;

   


    public void Init()
    {
        this.inputField.text = "";
       // this.inputField = GetComponentInChildren<TMP_InputField>();
        this.inputField.onValueChanged.AddListener((str) =>
        {
            
            if (string.IsNullOrEmpty(this.inputField.text))
            {
                this.DisabledButton();
            }
            else
            {
                //Debug.Log(str);
                this.AbledButton();
            }
        });


        this.abledBtn.onClick.AddListener(() =>
        {
            Debug.Log(this.inputField.text);

        });

        this.disabledBtn.onClick.AddListener(() =>
        {
            Debug.Log("닉네임을 입력해라");
        });
    }

    private void AbledButton()
    {
        this.abledBtn.gameObject.SetActive(true);
        this.disabledBtn.gameObject.SetActive(false);

    }

    private void DisabledButton()
    {
        this.abledBtn.gameObject.SetActive(false);
        this.disabledBtn.gameObject.SetActive(true);
    }

}
