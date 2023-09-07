using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIChestScrollView : MonoBehaviour
{
    [SerializeField]
    private UIChestCell[] cells;
    
    // Start is called before the first frame update
    void Start()
    {
        //foreach (ChestData data in chestDatas)
        //{
        //    Debug.LogFormat("{0} {1} {2} {3} {4}", data.id, data.name, data.type, data.price, data.sprite_name);
        //}

        for (int i = 0; i < cells.Length; i++)
        {
            UIChestCell cell = cells[i];
            cell.onClickPrice = () =>
            {
                Debug.LogFormat("상자타입:{0},가격:{1}", cell.ChestType, cell.Price);
            };

            UIChestCellAd cellAd = cell as UIChestCellAd;
            if (cellAd != null)
            {
                cellAd.onClickAd = () =>
                {
                    Debug.LogFormat("{0}, 광고보기", cell.ChestType);
                };
            }
            //cell.Init(data);
        }
    }

    public void Init()
    {
        List<ChestData> chestDatas = DataManager.instance.GetChestDatas();
        foreach (ChestData data in chestDatas)
        {
            Debug.LogFormat("{0} {1} {2} {3} {4}", data.id, data.name, data.type, data.price, data.sprite_name);
        }
    }

}
