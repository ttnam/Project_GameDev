using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class Wonder
{

    private string mId;
    private string mName;
    private string mNation;
    private Vector3 mPosition = new Vector3();
    private Vector3 mRotation = new Vector3();
    private List<string> mImages;


    public Wonder()
    {
        this.mId = "";
        this.mName = "";
        this.mNation = "";
        this.mImages = new List<string>();
    }
    public Wonder(string id, string name, string nation,
        Vector3 rotation, Vector3 position, List<string> images
        )
    {
        this.mId = id;
        this.mName = name;
        this.mNation = nation;
        this.mImages = images;
    }

    public Vector3 getPostion()
    {
        return this.mPosition;
    }
    public Vector3 getRotation()
    {
        return this.mRotation;
    }
    public string getName()
    {
        return this.mName;
    }

    public List<string> getImages()
    {
        return this.mImages;
    }
}
