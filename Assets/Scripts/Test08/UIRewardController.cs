using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIRewardController : MonoBehaviour
{
    [SerializeField] 
    private UIRewardCell[] uIRewardCells;
    [SerializeField]
    private GameObject uiRewardPrefab;
    [SerializeField]
    private Transform grid;
    // Start is called before the first frame update

    [SerializeField]
    private string[] arrFrameNames;
    [SerializeField]
    private string[] arrRewardNames;
    [SerializeField]
    private string[] arrLightNames;
    [SerializeField]
    private string[] arrAmounts;

    public void Init()
    {
        for (int i = 0; i < 5; i++)
        {
            UIRewardCell cell = null;
            GameObject go = Instantiate<GameObject>(this.uiRewardPrefab, grid);
            cell = go.GetComponent<UIRewardCell>();
            cell.Init(arrFrameNames[i], arrRewardNames[i], arrLightNames[i], arrAmounts[i]);//arrFrameNames[i],arrRewardNames[i],arrLightNames[i],arrAmounts[i]
        }
    }

}
