using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test03UIMain : MonoBehaviour
{
    [SerializeField]
    private UIStage uiStage;
    [SerializeField]
    private Test03UIContoller stagecontorller;


    

    //버튼들을 배열로 관리
    [SerializeField]
    private Button[] arrBtn;
    // Start is called before the first frame update
    void Start()
    {
        //this.uiStage.Init(1); //stage 넘버를 1로초기화
        this.stagecontorller.Init();
        //for(int i = 0; i<this.arrBtn.Length; i++) { 
        
        //    Button btn = this.arrBtn[i]; //배열의 길이 만큼 돌면서
        //    int idx = i; //인덱스에 값넣어주기
        //    //버튼을 클릭하면
        //    btn.onClick.AddListener(() =>
        //    {
        //        var state = (UIStage.eState)idx;// 유아이스테이지의 이넘 스테이트로 바꿔주기
        //        //인덱스와 상태 찍어보기
        //        Debug.LogFormat("{0},{1}",idx,state);
        //        //상태 체인지
        //        this.uiStage.ChangeState(state);
        //    });

        //}
        
    }
    
}
