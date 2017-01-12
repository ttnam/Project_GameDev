using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LitJson;

public class WonderManager
{
    private Dictionary<int, Wonder> mWonders;
    private static WonderManager _instance;
    public static string FILE_PATH = "wonders.json";

    private WonderManager()
    {
        mWonders = new Dictionary<int, Wonder>();
        onInitData();
    }
    public static WonderManager getInstance()
    {
        if (_instance == null)
        {
            _instance = new WonderManager();
        }
        return _instance;
    }

    private void onInitData()
    {
        string filePath = FILE_PATH.Replace(".json", "");
        TextAsset targetFile = Resources.Load<TextAsset>(filePath);
        string json = targetFile.text;

        // Array

        // Object
        JsonData jsondata = JsonMapper.ToObject(json);

        Wonder wonder = new Wonder(
            jsondata["id"].ToString(),
            jsondata["name"].ToString(),
            jsondata["nation"].ToString()
            );
            
//             ;

        
        Debug.LogError(wonder);
    }

    public Dictionary<int, Wonder> getWonders()
    {
        return mWonders;
    }

    public Wonder getWonder(int id)
    {
        if (id < 1 || id >= this.mWonders.Count)
        {
            return this.mWonders[id];
        }
        return null;
    }
    public Vector3 getPositionByWonderId(int id)
    {
        return getWonder(id).getPostion();
    }
    public Vector3 getRotationByWonderId(int id)
    {
        return getWonder(id).getRotation();
    }
    public string getNameByWonderId(int id)
    {
        return getWonder(id).getName();
    }
    public List<string> getImagesByWonderId(int id)
    {
        return getWonder(id).getImages();
    }

}
