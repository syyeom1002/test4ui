using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIChestCellAd : UIChestCell
{
    [SerializeField]
    private Button btnAd;
    public System.Action onClickAd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void Init(ChestData data,Sprite sprite)
    {
        
        this.btnAd.onClick.AddListener(() =>
        {
            Debug.LogFormat("{0}: ±¤°íº¸±â", this.chestType);
            this.onClickAd();
        });
    }
    
}
