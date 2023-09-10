using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGoldScrollView : MonoBehaviour
{
    [SerializeField]
    private UIGoldCell[] goldCells;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < goldCells.Length; i++)
        {
            UIGoldCell cell = goldCells[i];
            cell.onClickPrice = () =>
            {
                Debug.LogFormat("<color=blue>타입: {0},가격 {1}</color>", cell.GoldType, cell.Price);
            };
            cell.Init();
        }
    }
}
