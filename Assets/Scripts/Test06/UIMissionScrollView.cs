using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class UIMissionScrollView : MonoBehaviour
{
    //[SerializeField]
    //private UIMissionCell[] cells;
    [SerializeField]
    private GameObject UiMissionCellPrefab;
    [SerializeField]
    private SpriteAtlas atlas;
    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0; i < cells.Length; i++)
        //{
        //    UIMissionCell cell = cells[i];
        //    Debug.LogFormat("<color=yellow>data.icon_name:{0}</color>", cell.Icon_name);
        //}
    }

    public void Init()
    {
        List<MissionData> missionDatas = DataManager.instance.GetMissionDatas();
        foreach(MissionData data in missionDatas)
        {
            Debug.LogFormat("<color=green>id:{0}, name:{1}</color>", data.id, data.name);
        }
    }
}
