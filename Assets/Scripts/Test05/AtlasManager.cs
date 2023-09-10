using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;
using System;
public class AtlasManager : MonoBehaviour
{
    [SerializeField]
    private string[] arrAtlasNames;

    private Dictionary<string, SpriteAtlas> dicAtlases = new Dictionary<string, SpriteAtlas>();
    public static AtlasManager instance;
    // Start is called before the first frame update
    private void Awake()
    {
        if(instance!=null&& instance != this)
        {
            Destroy(this);
            throw new System.Exception("An instance of this singleton already exits.");
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    public void LoadAtlases()
    {
        foreach(var atlasName in this.arrAtlasNames)
        {
            var atlas = Resources.Load<SpriteAtlas>(atlasName);
            this.dicAtlases.Add(atlasName, atlas);
        }
        Debug.LogFormat("{0}개의 아틀라스를 로드 했습니다. ", this.dicAtlases.Count);
    }
    public SpriteAtlas GetAtlas(string atlasName)
    {
        return this.dicAtlases[atlasName];
    }
}
