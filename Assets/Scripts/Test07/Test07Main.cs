using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test07Main : MonoBehaviour
{
    [SerializeField]
    private UIGoldScrollView scrollView;
    // Start is called before the first frame update
    void Start()
    {
        DataManager.instance.LoadGoldData();
        AtlasManager.instance.LoadAtlases();
        this.scrollView.Init();
    }

}
