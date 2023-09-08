using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test06UIMain : MonoBehaviour
{
    [SerializeField]
    private UIMissionScrollView missionScrollView;
    // Start is called before the first frame update
    void Start()
    {
        DataManager.instance.LoadMissionData();
        this.missionScrollView.Init();
    }

}
