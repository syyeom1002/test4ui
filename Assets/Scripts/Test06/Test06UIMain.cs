using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.IO;
using UnityEditor;
using JetBrains.Annotations;

public class Test06UIMain : MonoBehaviour
{
    [SerializeField]
    private UIMissionScrollView missionScrollView;
    [SerializeField]
    protected Button btnSave;

    private string fileName = "mission_infos.json";
    private string path;
    private List<MissionInfo> missionInfos;
    // Start is called before the first frame update
    void Start()
    {
        DataManager.instance.LoadMissionData();
        AtlasManager.instance.LoadAtlases();
        
        this.missionScrollView.Init();

        this.btnSave.onClick.AddListener (() =>
        {
            Debug.Log("save");
            this.Save();
        });
    }
    private void Save()
    {
        List<UIMissionCell>cells=this.missionScrollView.GetMissionCells();
        //����ȭ ��� ��ü ����� 
        List<MissionInfo> missionInfos = new List<MissionInfo>();
        foreach(UIMissionCell cell in cells)
        {
            Debug.LogFormat("{0}{1}", cell.Id, cell.Count);
            MissionInfo info = new MissionInfo(cell.Id, cell.Count);
            missionInfos.Add(info);
        }

        //����ȭ
        string json = JsonConvert.SerializeObject(missionInfos);
        Debug.LogFormat("<color=red>{0}</color>",json);

        //���Ϸ� ����
        string fileName = "mission_infos.json";
        string path = string.Format("{0}/{1}", Application.persistentDataPath, fileName);
        Debug.Log(path);

        File.WriteAllText(path, json);
        Debug.Log("<color=yellow>SAVED!</color>");
        EditorUtility.RevealInFinder(Application.persistentDataPath); //���� ��ġ ������ �ϴ°�
    }
}
