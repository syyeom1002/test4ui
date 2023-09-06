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
            uiStage.Init(i+1); //ù��° ��������
            uiStage.btn.onClick.AddListener(() => {
                uiStage.ChangeState(UIStage.eState.Complete);
                //Debug.LogFormat("{0},{1}", idx, uiStage);
                
            });
        }

        //ù��° ���������� ã�Ƽ� ���»��·� �����
        this.uiStages[0].ChangeState(UIStage.eState.Doing);
        
        



    }
}
