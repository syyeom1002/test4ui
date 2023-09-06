using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
public class Test04UIMain : MonoBehaviour
{
    [SerializeField]
    private Button btnPrev;
    [SerializeField]
    private Button btnNext;

    [SerializeField]
    private int totalStage = 28;
    private int currentPage = 1;
    private const int MAX_STAGE_NUM = 18;

    [SerializeField]
    private Test04UIPageStage uiPageStage;
    [SerializeField]
    private Test04UIStageController uiStageController;
    // Start is called before the first frame update

    void Start()
    {
        this.uiStageController.Init();
        ////this.Display();
        //this.btnPrev.onClick.AddListener(() =>
        //{
        //    Debug.Log("이전 페이지로 가기");
        //});
        //this.btnNext.onClick.AddListener(() =>
        //{
        //    Debug.Log("다음 페이지로 가기");
        //    currentPage += 1;
        //    this.Display();
            
        //});
    }

    private void Display()
    {
        //마지막 페이지는 전체스테이지/ 최대 스테이지
        int endPage = Mathf.CeilToInt((float)totalStage / MAX_STAGE_NUM);
        Debug.LogFormat("총 스테이지:{0}", totalStage);
        Debug.LogFormat("현재 페이지:{0}", currentPage);
        Debug.LogFormat("마지막 페이지:{0}",endPage);
        //한 페이지에 보여줄 수   있는 최대 스테이지 수  현재페이지 *18
        //시작 스테이지 수= 현재페이지*18 -17
        int endStage = currentPage * MAX_STAGE_NUM;
        int startStage = currentPage * MAX_STAGE_NUM - 17;
        if (endPage == currentPage)
        {
            endStage = totalStage;
        }
        Debug.LogFormat("스테이지:{0}~{1}",startStage,endStage);
    }
}
