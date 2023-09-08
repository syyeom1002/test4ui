using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class UIChestScrollView : MonoBehaviour
{
    [SerializeField]
    private UIChestCell[] cells;
    [SerializeField]
    private GameObject uiChestCellAdPrefab;
    [SerializeField]
    private GameObject uiChestCellPrefab;
    [SerializeField]
    private Transform content;
    [SerializeField]
    private SpriteAtlas atlas;

    // private List<UIChestCell> cellList = new List<UIChestCell>();

    // Start is called before the first frame update

    private void Start()
    {
        for (int i = 0; i < cells.Length; i++)
        {
            UIChestCell cell = cells[i];
            cell.onClickPrice = () =>
            {
                Debug.LogFormat("상자타입:{0}, 가격{1}", cell.ChestType, cell.Price);
            };

            UIChestCellAd cellAd = cell as UIChestCellAd;
            if (cellAd != null)
            {
                cellAd.onClickAd = () =>
                {
                    Debug.LogFormat("{0}, 광고보기", cell.ChestType);
                };
            }
           
        }
    }

    public void Init()
    {
        List<ChestData> chestDatas = DataManager.instance.GetChestDatas();
        foreach (ChestData data in chestDatas)
        { 
            
            Debug.LogFormat("{0} {1} {2} {3} {4}", data.id, data.name, data.type, data.price, data.sprite_name);
            Sprite sprite = this.atlas.GetSprite(data.sprite_name);
            if(data.type==0)
            {
                GameObject uiChestCellGo = Instantiate(this.uiChestCellAdPrefab, this.content);
                UIChestCell cell = uiChestCellGo.GetComponent<UIChestCell>();
                cell.Init(data, sprite);
            }
            else
            {
                GameObject uiChestCellGo = Instantiate(this.uiChestCellPrefab, this.content);
                UIChestCell cell = uiChestCellGo.GetComponent<UIChestCell>();
                cell.Init(data, sprite);
            }
        }
    }

}
