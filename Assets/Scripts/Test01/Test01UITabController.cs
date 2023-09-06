using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01UITabController : MonoBehaviour
{
    public enum eMenu
    {
        Package,
        Card,
        Equipment
    }

    private eMenu selectedMenu;
    [SerializeField]
    private Test01UITab[] uiTabs;
    [SerializeField]
    private string[] arrMenuNames;

    public void Init()
    {
        for(int i = 0; i<this.uiTabs.Length; i++)
        {
            int idx = i;
            var uiTab = this.uiTabs[i];
            uiTab.Init();
            uiTab.btn.onClick.AddListener(() =>
            {
                this.SelectedMenu((eMenu)idx);
            });
        }
        this.SelectedMenu(eMenu.Package); //기본타입?
    }

    private void SelectedMenu(eMenu menu)
    {
        foreach (var Tab in this.uiTabs)
        {
            Tab.UnTab();
        }

        int idx = (int)menu;
        var uiTab = this.uiTabs[idx];
        uiTab.Tab();

        this.selectedMenu = menu;
    }
}
