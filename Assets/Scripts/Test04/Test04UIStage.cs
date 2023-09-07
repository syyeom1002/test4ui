using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Test04UIStage : MonoBehaviour
{
    [SerializeField]
    private TMP_Text txtStageNum;
    public enum eState
    {
        Lock, Doing, Complete
    }
    [SerializeField]
    private GameObject[] arrStateGo;
    private eState state;
    public System.Action<int,eState> onClick;
    public Button btn;
    private int stageNum;   //기본값 0
    // Start is called before the first frame update
    public void Init(int stageNum)
    {
        this.stageNum = stageNum;

        this.txtStageNum.text = stageNum.ToString();//숫자를 문자열로
        //this.ChangeState(eState.Lock);
        this.btn.onClick.AddListener(() =>
        {
            Debug.LogFormat("Test04UIStage: {0}", this.stageNum);
            this.onClick(this.stageNum,this.state);
        });
    }
    //public void ChangeState(eState state)
    //{
    //    this.InActiveAll();

       //this.state = state;
       //int index = (int)this.state;
    //    this.arrStateGo[index].SetActive(true);
    //}//changeState(lock)하면 나머지는 다 inactive하고 lock만 active하는 함수

    //private void InActiveAll()
    //{
    //    foreach (var go in this.arrStateGo)
    //    {
    //        go.SetActive(false);
    //    }
    //}
}
