using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIChestCell : MonoBehaviour
{
    public enum eChestType
    {
        Wooden,Silver,Golden,Epic,Legendary
    }
    [SerializeField]
    protected Button btnPrice;
    [SerializeField]
    protected eChestType chestType;
    [SerializeField]
    protected int price;
    //[SerializeField]
    //private TMP_Text txtPrice;
    //[SerializeField]
    //private TMP_Text txtName;
    //[SerializeField]
    //private Image icon;

    public System.Action onClickPrice;

    public eChestType ChestType
    {
        get
        {
            return this.chestType;
        }
    }
    public int Price
    {
        get
        {
            return this.price;
        }
    }
    
    // Start is called before the first frame update
  
    public virtual void Init(ChestData data)
    {
        //this.price = data.price;
        //this.txtName.text = data.name;
        //this.txtPrice.text = this.price.ToString();
        //this.chestType = (eChestType)data.type;
        this.btnPrice.onClick.AddListener(() =>
        {
            Debug.LogFormat("상자타입:{0},가격:{1}", this.chestType, this.price);
            onClickPrice();
        });
    }
   
    
}
