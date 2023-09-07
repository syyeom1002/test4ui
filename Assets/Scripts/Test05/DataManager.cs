using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.Runtime.InteropServices.WindowsRuntime;
using Newtonsoft.Json.Bson;
using System.Linq;


public class DataManager :MonoBehaviour
{
    public static readonly DataManager instance = new DataManager();
    private Dictionary<int, ChestData> dicChestDatas = new Dictionary<int, ChestData>();
    // Start is called before the first frame update
    private DataManager()
    {

    }
    public void LoadChestData()
    {
        TextAsset asset = Resources.Load<TextAsset>("chest_data");
        Debug.Log(asset.text);

        ChestData[] chestDatas = JsonConvert.DeserializeObject<ChestData[]>(asset.text);
        foreach (ChestData data in chestDatas)
        {
            this.dicChestDatas.Add(data.id, data);
        }
        Debug.LogFormat("dicchestDatas:{0}", dicChestDatas.Count); 
    }

    public List<ChestData> GetChestDatas()
    {
        return this.dicChestDatas.Values.ToList();
    }
}
