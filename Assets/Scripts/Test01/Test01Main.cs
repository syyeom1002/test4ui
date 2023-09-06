using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01Main : MonoBehaviour
{
    [SerializeField]
    private Test01UIMain uIMain;
    // Start is called before the first frame update
    void Start()
    {

        this.uIMain.onButtonClicked = (btnType) => {
            Debug.Log(btnType);
        };
        this.uIMain.Init();
    }

   
}
