using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test01UIMain : MonoBehaviour
{

    public enum eButtonType
    {
        Blue, Red, Green, Purple
    }
    //[SerializeField]
    //private Button btnBlue;
    //[SerializeField]
    //private Button btnRed;
    //[SerializeField]
    //private Button btnGreen;
    //[SerializeField]
    //private Button btnPurple;
    [SerializeField]
    private Button[] btns;
    [SerializeField]
    private Test01UITabController tabController;

    [SerializeField]
    private Test01UISlider uISlider;

    public System.Action<eButtonType> onButtonClicked;
    public void Init()
    {
        this.tabController.Init();
        //for (int i = 0; i < btns.Length; i++)
        //{
        //    Button btn = this.btns[i];
        //    int idx = i; //캡처
        //    btn.onClick.AddListener(() => {
        //        //클로져: 람다  안에서 상위 스코프 변수에 접근
                
        //    });

        //    }

    //    this.btnBlue.onClick.AddListener(() => {
    //        Debug.Log("blue버튼 클릭");
    //        this.onButtonClicked(eButtonType.Blue);
    //    });
    //    this.btnRed.onClick.AddListener(() => {
    //        Debug.Log("red버튼 클릭");
    //        this.onButtonClicked(eButtonType.Red);
    //    });
    //    this.btnGreen.onClick.AddListener(() => {
    //        Debug.Log("green버튼 클릭");
    //        this.onButtonClicked(eButtonType.Green);
    //    });
    //    this.btnPurple.onClick.AddListener(() => {
    //        Debug.Log("purple버튼 클릭");
    //        this.onButtonClicked(eButtonType.Purple);
    //    });

    }

    
}
