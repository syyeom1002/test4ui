using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class UIMissionScrollView : MonoBehaviour
{
    
    [SerializeField]
    private Transform content;
    [SerializeField]
    private GameObject UiMissionCellPrefab;
    [SerializeField]
    private SpriteAtlas atlas;

    //1.��ü�� �׷�ȭ�ϰ� �����ϴ� ��� 2����(�迭, �÷���)
    private List<UIMissionCell> uiMissionCells;

    public void Init(List<MissionInfo> missionInfos)//�� init�ȿ� missioninfo �÷�����..? 
    {
        //�÷��� ����ϱ� ���� �ݵ�� �ν��Ͻ�ȭ
        this.uiMissionCells = new List<UIMissionCell>();

        //List<MissionData> missionDatas = DataManager.instance.GetMissionDataList();
        //for (int i = 0; i < missionDatas.Count; i++)
        //{
        //    MissionData data = missionDatas[i];
        //    this.CreateUIMissionCell(data);
        //}
        //List<MissionData> missionDatas = DataManager.instance.GetMissionDatas();
        //foreach (MissionData data in missionDatas)
        //{
        //    Debug.LogFormat("<color=green>id:{0}, name:{1}</color>", data.id, data.name);
        //    UIMissionCell cell = null;
        //    GameObject go = Instantiate<GameObject>(this.UiMissionCellPrefab, content);
        //    cell = go.GetComponent<UIMissionCell>();
        //    cell.Init(data);
        //}
        foreach(var missionInfo in missionInfos)
        {
            this.CreateUIMissionCell(missionInfo);//�̼�cell�� ����? missionInfo�� ������� ..?????
        }
    }
    private void CreateUIMissionCell(MissionInfo info)
    {
        GameObject go = Instantiate(this.UiMissionCellPrefab, this.content);
        UIMissionCell cell = go.GetComponent<UIMissionCell>();
        //cell.Init(info);

        //�÷��ǿ� �߰� 
        this.uiMissionCells.Add(cell);
    }
    public List<UIMissionCell> GetMissionCells()
    {
        return uiMissionCells;
    }
}
