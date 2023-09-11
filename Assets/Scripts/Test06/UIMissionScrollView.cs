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

    //1.객체를 그룹화하고 관리하는 방법 2가지(배열, 컬렉션)
    private List<UIMissionCell> uiMissionCells;

    public void Init(List<MissionInfo> missionInfos)//왜 init안에 missioninfo 컬렉션이..? 
    {
        //컬렉션 사용하기 전에 반드시 인스턴스화
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
            this.CreateUIMissionCell(missionInfo);//미션cell을 생성? missionInfo를 기반으로 ..?????
        }
    }
    private void CreateUIMissionCell(MissionInfo info)
    {
        GameObject go = Instantiate(this.UiMissionCellPrefab, this.content);
        UIMissionCell cell = go.GetComponent<UIMissionCell>();
        //cell.Init(info);

        //컬렉션에 추가 
        this.uiMissionCells.Add(cell);
    }
    public List<UIMissionCell> GetMissionCells()
    {
        return uiMissionCells;
    }
}
