using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.U2D;

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
    protected TMP_Text txtPrice;
    [SerializeField]
    protected TMP_Text txtAmount;
    [SerializeField]
    protected TMP_Text txtName;
    [SerializeField]
    protected float price;

    [SerializeField]
    protected Image icon;
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
    public void Init(GoldData data)
    {
        this.price = data.price;
        this.txtName.text = data.name;
        this.txtAmount.text = string.Format("{0} Gold",data.amount.ToString());
        this.txtPrice.text = string.Format("US ${0}", this.price);
        var atlas = AtlasManager.instance.GetAtlas("GoldAtlas");
        this.icon.sprite = atlas.GetSprite(data.sprite_name);

        this.btnPrice.onClick.AddListener(() =>
        {
            Debug.LogFormat("이름:{0}, 가격:{1}", this.txtName.text, this.txtPrice.text);
            
        });
    }
    
}
