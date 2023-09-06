using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStage : MonoBehaviour
{
    public enum eState
    {
        Lock, Doing, Complete
    }

    [SerializeField]
    private TMP_Text[] arrTxtStageNum;

    [SerializeField]
    private GameObject[] arrStateGo;

    public Button btn; 

    private eState state;

    public void Init(int stageNum)
    {
        foreach(var tmpText in this.arrTxtStageNum)
        {
            tmpText.text = stageNum.ToString();
        }
        
        this.ChangeState(eState.Lock);
    }


    public void ChangeState(eState state)
    {
        this.InActiveAll();

        this.state = state;
        int index = (int)this.state;
        Debug.Log(index);
        
        //Debug.LogFormat("this.arrStateGo.Length: {0}", this.arrStateGo.Length);
        
        this.arrStateGo[index].SetActive(true);
    }
    private void InActiveAll()
    {
        foreach(var go in this.arrStateGo)
        {
            go.SetActive(false);
        }
    }
}
