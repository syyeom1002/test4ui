using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Test01UITab : MonoBehaviour
{
    [SerializeField]
    private TMP_Text[] arrText;

    [SerializeField]
    private GameObject tabbedGo;
    [SerializeField]
    private GameObject unTabbedGo;

    public Button btn;
   
    public void Init()
    {

    }


    public void Tab()
    {
        this.tabbedGo.SetActive(true);
        this.unTabbedGo.SetActive(false);
    }

    public void UnTab()
    {
        this.tabbedGo.SetActive(false);
        this.unTabbedGo.SetActive(true);
    }
   
}
