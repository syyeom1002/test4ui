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
        Lock,Doing,Complete
    }
    private eState state;
    public System.Action<int,eState> onClick;
    public Button btn;
    private int stageNum;   //기본값 0
    // Start is called before the first frame update
    public void Init(int stageNum)
    {
        this.stageNum = stageNum;

        this.txtStageNum.text = stageNum.ToString();//숫자를 문자열로
        this.btn.onClick.AddListener(() =>
        {
            Debug.LogFormat("Test04UIStage: {0}", this.stageNum);
            this.onClick(this.stageNum,this.state);
        });
    }
    public void ChangeState(eState state)
    {
        this.InActiveAll();
        this.state = state;
        
    }
    private void InActiveAll()
    {
        
    }
}
