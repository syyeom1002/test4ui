using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMissionCell : MonoBehaviour
{
    [SerializeField]
    protected string icon_name;
    public string Icon_name
    {
        get
        {
            return this.icon_name;
        }
    }
    
}
