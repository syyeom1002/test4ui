using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.IO;
using UnityEditor;
using JetBrains.Annotations;
using System.Linq;

public class Test06UIMain : MonoBehaviour
{
    [SerializeField]
    private UIMissionScrollView missionScrollView;
    [SerializeField]
    protected Button btnSave;

    private string fileName = "mission_infos.json";//파일 이름 
    private string path;//경로
    private List<MissionInfo> missionInfos; 
    // Start is called before the first frame update
    void Start()
    {
        DataManager.instance.LoadMissionData();
        AtlasManager.instance.LoadAtlases();
        
        //this.missionScrollView.Init();

        this.btnSave.onClick.AddListener (() =>
        {
            Debug.Log("save");
            this.Save();
        });

        if (this.IsNewbie())//신규회원이라면-> 파일이 없다면 ->data를 기반으로 MissionInfo
        {
            List<MissionData> missionDatas = DataManager.instance.GetMissionDataList();//미션데이터를 리스트로 가져와서 missionDatas라는 리스트(데이터기반)에다가 저장한다
            this.missionInfos = new List<MissionInfo>();//컬렉션 인스턴스화
            foreach(var data in missionDatas)
            {
                MissionInfo info = new MissionInfo(data.id, 0);
                this.missionInfos.Add(info);//missionInfos 컬렉션안에 mission id랑 count=0 추가??
            }
        }
        else//파일이 있다면 -> 불러와서 역직렬화
        {
            this.LoadMissionInfos();
        }
    }

    private void LoadMissionInfos()
    {
        string json = File.ReadAllText(path);//불러오기
        this.missionInfos = JsonConvert.DeserializeObject<MissionInfo[]>(json).ToList();//역직렬화(+배열->리스트형)
    }
    private bool IsNewbie()
    {
        if (File.Exists(path))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    private void Save()
    {
        List<UIMissionCell>cells=this.missionScrollView.GetMissionCells();
        //직렬화 대상 객체 만들기 
        List<MissionInfo> missionInfos = new List<MissionInfo>();
        foreach(UIMissionCell cell in cells)
        {
            Debug.LogFormat("{0}{1}", cell.Id, cell.Count);
            MissionInfo info = new MissionInfo(cell.Id, cell.Count);
            missionInfos.Add(info);
        }

        //직렬화
        string json = JsonConvert.SerializeObject(missionInfos);
        Debug.LogFormat("<color=red>{0}</color>",json);

        //파일로 저장
        string fileName = "mission_infos.json";
        string path = string.Format("{0}/{1}", Application.persistentDataPath, fileName);
        Debug.Log(path);

        File.WriteAllText(path, json);
        Debug.Log("<color=yellow>SAVED!</color>");
        EditorUtility.RevealInFinder(Application.persistentDataPath); //파일 위치 열리게 하는거
    }
}
