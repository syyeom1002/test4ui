using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGoldCell : MonoBehaviour
{
    public enum eGoldType
    {
        Tiny,Fistful,Pouch,Box,Chest,Vault
    }
    [SerializeField]
    protected Button btnPrice;
    [SerializeField]
    protected eGoldType goldType;
    [SerializeField]
    protected float price;

    public System.Action onClickPrice;
    public eGoldType GoldType
    {
        get
        {
            return this.goldType;
        }
    }
    public float Price
    {
        get
        {
            return this.price;
        }
    }
    // Start is called before the first frame update
    public void Init()
    {
        this.btnPrice.onClick.AddListener(() =>
        {
            Debug.LogFormat("타입:{0}, 가격:{1}", this.goldType, this.price);
            this.onClickPrice();
        });
        
    }
    
}
