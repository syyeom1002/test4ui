using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test01UIToggle : MonoBehaviour
{
    public enum eState
    {
        On,
        Off
    }
    private eState state; //기본값 0 =>On
    [SerializeField]
    private Button btn;

    [SerializeField]
    private GameObject[] arrOnOff;
    // Start is called before the first frame update
    void Start()
    {

        //var go = this.arrOnOff[(int)this.state];
        //go.SetActive(true);

        this.btn.onClick.AddListener(() =>
        {
            var prevState = this.state;
            Debug.LogFormat("토글버튼 클릭 :{0}", this.state);
            //이전상태 게임오브젝트 비활성화
            this.arrOnOff[(int)this.state].SetActive(false);
            //현재 상태를 반전시켜야함
            if(this.state == eState.On)
                this.state = eState.Off;
            else
                this.state = eState.On;

            this.arrOnOff[(int)this.state].SetActive(true);
            
        });
    }

    
}
