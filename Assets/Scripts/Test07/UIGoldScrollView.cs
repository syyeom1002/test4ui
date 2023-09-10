using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class UIGoldScrollView : MonoBehaviour
{
    [SerializeField]
    private GameObject uiGoldPrefab;
    [SerializeField]
    private Transform content;
    [SerializeField]
    private SpriteAtlas atlas;
    
    // Start is called before the first frame update
    public void Init()
    {
        List<GoldData> goldDatas = DataManager.instance.GetGoldDatas();
        
        foreach(GoldData data in goldDatas)
        {
            Debug.LogFormat("<color=yellow>id:{0}</color>,name:{1},type:{2},price:{3},amount:{4},{5}", data.id, data.name, data.type, data.price, data.amount,data.sprite_name);
            UIGoldCell cell = null;
            GameObject go = Instantiate<GameObject>(this.uiGoldPrefab, content);//contentÀ§Ä¡¿¡ 
            cell = go.GetComponent<UIGoldCell>();
            cell.Init(data);
            
        }
    }
}
