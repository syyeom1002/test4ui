using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03UIContoller : MonoBehaviour
{

    [SerializeField]
    private UIStage[] uiStages;
    
    public void Init()
    {

        for(int i = 0; i<uiStages.Length; i++)
        {
            int idx = i;
            var uiStage= this.uiStages[i];
            uiStage.Init(i+1); //첫번째 스테이지
            uiStage.btn.onClick.AddListener(() => {
                uiStage.ChangeState(UIStage.eState.Complete);
                //Debug.LogFormat("{0},{1}", idx, uiStage);
                
            });
        }

        //첫번째 스테이지를 찾아서 오픈상태로 만들기
        this.uiStages[0].ChangeState(UIStage.eState.Doing);
        
        



    }
}
