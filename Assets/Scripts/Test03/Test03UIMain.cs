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


    

    //��ư���� �迭�� ����
    [SerializeField]
    private Button[] arrBtn;
    // Start is called before the first frame update
    void Start()
    {
        //this.uiStage.Init(1); //stage �ѹ��� 1���ʱ�ȭ
        this.stagecontorller.Init();
        //for(int i = 0; i<this.arrBtn.Length; i++) { 
        
        //    Button btn = this.arrBtn[i]; //�迭�� ���� ��ŭ ���鼭
        //    int idx = i; //�ε����� ���־��ֱ�
        //    //��ư�� Ŭ���ϸ�
        //    btn.onClick.AddListener(() =>
        //    {
        //        var state = (UIStage.eState)idx;// �����̽��������� �̳� ������Ʈ�� �ٲ��ֱ�
        //        //�ε����� ���� ����
        //        Debug.LogFormat("{0},{1}",idx,state);
        //        //���� ü����
        //        this.uiStage.ChangeState(state);
        //    });

        //}
        
    }
    
}
