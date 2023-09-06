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
    private eState state; //�⺻�� 0 =>On
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
            Debug.LogFormat("��۹�ư Ŭ�� :{0}", this.state);
            //�������� ���ӿ�����Ʈ ��Ȱ��ȭ
            this.arrOnOff[(int)this.state].SetActive(false);
            //���� ���¸� �������Ѿ���
            if(this.state == eState.On)
                this.state = eState.Off;
            else
                this.state = eState.On;

            this.arrOnOff[(int)this.state].SetActive(true);
            
        });
    }

    
}
