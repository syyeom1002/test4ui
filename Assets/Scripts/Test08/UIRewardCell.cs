using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class UIRewardCell : MonoBehaviour
{
    public enum eRewardType
    {
        Potion,Gem,Coin,Book,Gift
    }
    [SerializeField]
    private Animator animReward;
    [SerializeField]
    private TMP_Text txtAmount;

    [SerializeField]
    private Image frame;
    [SerializeField]
    private Image light;
    [SerializeField]
    private Image reward;
    
    // Start is called before the first frame update
    public void Init(string frame, string reward, string light, string txtAmount)
    {
        this.txtAmount.text = txtAmount;
        var atlas = Resources.Load<SpriteAtlas>("UIClearAtlas");
        this.frame.sprite = atlas.GetSprite(frame);
        this.light.sprite = atlas.GetSprite(light);
        this.reward.sprite = atlas.GetSprite(reward);
        this.animReward.SetTrigger("Play");
    }

}
