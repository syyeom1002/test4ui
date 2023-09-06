using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test01UICheckBox : MonoBehaviour
{

    public enum eState
    {
        
        Unchecked,
        Checked
    }
    private eState state;
    [SerializeField]
    private Button btn;
    [SerializeField]
    private GameObject[] arrChecked;
    // Start is called before the first frame update
    void Start()
    {
        this.btn.onClick.AddListener(() =>
        {
            var prevState = this.state;
            this.arrChecked[(int)this.state].SetActive(true);
            if(this.state == eState.Checked)
                this.state = eState.Unchecked;
            else
                this.state =eState.Checked;
            this.arrChecked[(int)this.state].SetActive(false);



        });
    }

  
}
