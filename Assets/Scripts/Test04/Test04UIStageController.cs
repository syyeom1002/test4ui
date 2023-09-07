using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test04UIStageController : MonoBehaviour
{
    //stage ���� �����ϴ� ��ũ��Ʈ�ϱ� Controller�� -> stage�� �迭��
    [SerializeField]
    private Test04UIStage[] uiStages;
    // Start is called before the first frame update

    public void Init()
    {

        for(int i = 0; i < uiStages.Length; i++)
        {
            int stageNum = i + 1;
            Debug.Log(stageNum);
            var uiStage = this.uiStages[i];
            uiStage.onClick = (stageNum,state) =>
            {

                Debug.LogFormat("[Test04UIStageController] stageNum:{0},state:{1}", stageNum,state);
            };
            
            uiStage.Init(stageNum);

        }
        //this.uiStages[0].ChangeState(Test04UIStage.eState.Doing);
    }
}
