using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Test08Main : MonoBehaviour
{
    [SerializeField]
    private UIRewardController rewardController;

    [SerializeField]
    private Button btnRibbonPlay;
    [SerializeField]
    private Button btnLeftStar;
    [SerializeField]
    private Button btnMiddleStar;
    [SerializeField]
    private Button btnRightStar;
    [SerializeField]
    private TMP_Dropdown dropdown;
    [SerializeField]
    private Button btnStarsPlay;

    [SerializeField]
    private Animator animRibbon;
    [SerializeField]
    private Animator animLeftStar;
    [SerializeField]
    private Animator animMiddleStar;
    [SerializeField]
    private Animator animRightStar;

    [SerializeField]
    private ParticleSystem[] fxStars;
    [SerializeField]
    private ParticleSystem particleBurst;
    private int starCount = 1;
    // Start is called before the first frame update
    void Start()
    {
        
        this.btnRibbonPlay.onClick.AddListener(() =>
        {
            this.animRibbon.SetTrigger("Play");
        });

        this.btnLeftStar.onClick.AddListener(() =>
        {
            this.animLeftStar.SetTrigger("Play");
        });

        this.btnMiddleStar.onClick.AddListener(() =>
        {
            this.animMiddleStar.SetTrigger("Play");
        });

        this.btnRightStar.onClick.AddListener(() =>
        {
            this.animRightStar.SetTrigger("Play");
        });
        this.dropdown.onValueChanged.AddListener((index) =>
        {
            this.starCount = index+1;
        });
        this.btnStarsPlay.onClick.AddListener(() =>
        {
            Debug.LogFormat("{0}개의 애니메이션 실행", this.starCount);

            switch (this.starCount)
            {
                case 1:
                    this.animLeftStar.GetComponent<AnimationReceiver>().OnFinished = () =>
                    {
                        var fx = this.fxStars[0];
                        fx.gameObject.SetActive(true);
                        fx.Play();
                    };
                    this.animLeftStar.SetTrigger("Play");
                    this.animRibbon.SetTrigger("Play");
                    
                    
                    break;

                case 2:
                    this.animLeftStar.GetComponent<AnimationReceiver>().OnFinished = () =>
                    {
                        var fx = this.fxStars[0];
                        fx.gameObject.SetActive(true);
                        fx.Play();

                        this.animMiddleStar.GetComponent<AnimationReceiver>().OnFinished = () =>
                        {
                            var fx1 = this.fxStars[1];
                            fx1.gameObject.SetActive(true);
                            fx1.Play();
                        };
                        this.animMiddleStar.SetTrigger("Play");
                    };
                    this.animLeftStar.SetTrigger("Play");
                    this.animRibbon.SetTrigger("Play");
                    
                    break;
                case 3:
                    this.animLeftStar.GetComponent<AnimationReceiver>().OnFinished = () =>
                    {
                        var fx = this.fxStars[0];
                        fx.gameObject.SetActive(true);
                        fx.Play();
                        this.animMiddleStar.GetComponent<AnimationReceiver>().OnFinished = () =>
                        {
                            var fx1 = this.fxStars[1];
                            fx1.gameObject.SetActive(true);
                            fx1.Play();

                            this.animRightStar.GetComponent<AnimationReceiver>().OnFinished=()=>
                            {
                                var fx2 = this.fxStars[2];
                                fx2.gameObject.SetActive(true);
                                fx2.Play();
                                var pb = this.particleBurst;
                                pb.gameObject.SetActive(true);
                                pb.Play();
                            };
                            this.animRightStar.SetTrigger("Play");
                        };
                        this.animMiddleStar.SetTrigger("Play");
                    };
                    this.animLeftStar.SetTrigger("Play");
                    this.animRibbon.SetTrigger("Play");
                    this.rewardController.Init();
                    
                    break;
            }
        });
    }

    
}
