using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;
using System;

public class UIMissionCell : MonoBehaviour
{
    public enum eState
    {
        Doing,Complete
    }
    [SerializeField]
    protected string icon_name;
    [SerializeField]
    private TMP_Text txtMissionProgress;
    [SerializeField]
    private TMP_Text txtMissionName;
    [SerializeField]
    private TMP_Text txtMissionDesc;
    [SerializeField]
    private Image missionIcon;
    [SerializeField]
    private Image rewardIcon;

    public Slider slider;
    private int doingAmount = 0;
    private MissionData data;
    public string Icon_name
    {
        get
        {
            return this.icon_name;
        }
    }
    public int Id
    {
        get
        {
            return this.data.id;
        }
    }
    private int count;
    public int Count
    {
        get
        {
            return this.count;
        }
    }
    public void Init(MissionData data)
    {
        this.data = data;
        this.txtMissionName.text = data.name;
        this.txtMissionDesc.text = data.desc;
        var atlas = AtlasManager.instance.GetAtlas("UIMissionAtlas");
        this.missionIcon.sprite = atlas.GetSprite(data.icon_name);
        this.rewardIcon.sprite = atlas.GetSprite(data.reward_icon_name);
        this.txtMissionProgress.text = string.Format("0 / {0}", data.goal);

        float progress = (float)this.doingAmount / this.data.goal;
        Debug.LogFormat("<color=lime>{0}%</color>", progress);
        this.slider.value = progress;
    }
    public void ApplyCount(int count)
    {
        this.count = count;
        Debug.LogFormat("{0}({1})미션을 {2}개 진행 했습니다",this.data.name,this.data.id,count);
        float percent = (float)count / this.data.goal;
        this.slider.value = percent;
    }
    public int GetGoal()
    {
        if (this.data == null) return -1 ;
        return this.data.goal;
    }
}
