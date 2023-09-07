using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test05Main : MonoBehaviour
{
    [SerializeField]
    private UIChestScrollView chestScrollView;
    // Start is called before the first frame update
    void Start()
    {
        DataManager.instance.LoadChestData();
        this.chestScrollView.Init();
    }

}
