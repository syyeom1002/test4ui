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
        //    Debug.Log("���� �������� ����");
        //});
        //this.btnNext.onClick.AddListener(() =>
        //{
        //    Debug.Log("���� �������� ����");
        //    currentPage += 1;
        //    this.Display();
            
        //});
    }

    private void Display()
    {
        //������ �������� ��ü��������/ �ִ� ��������
        int endPage = Mathf.CeilToInt((float)totalStage / MAX_STAGE_NUM);
        Debug.LogFormat("�� ��������:{0}", totalStage);
        Debug.LogFormat("���� ������:{0}", currentPage);
        Debug.LogFormat("������ ������:{0}",endPage);
        //�� �������� ������ ��   �ִ� �ִ� �������� ��  ���������� *18
        //���� �������� ��= ����������*18 -17
        int endStage = currentPage * MAX_STAGE_NUM;
        int startStage = currentPage * MAX_STAGE_NUM - 17;
        if (endPage == currentPage)
        {
            endStage = totalStage;
        }
        Debug.LogFormat("��������:{0}~{1}",startStage,endStage);
    }
}
