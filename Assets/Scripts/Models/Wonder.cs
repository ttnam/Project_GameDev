using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class Wonder
{

    private int mId;
    private string mName;
    private string mNation;
    private Vector3 mPosition = new Vector3();
    private Vector3 mRotation = new Vector3();
    private List<string> mImages;


    public Wonder()
    {
        this.mId = -1;
        this.mName = "";
        this.mNation = "";
        this.mImages = new List<string>();
    }
    public Wonder(int id, string name, string nation,
        Vector3 rotation, Vector3 position, List<string> images
        )
    {
        this.mId = id;
        this.mName = name;
        this.mNation = nation;
        this.mImages = images;
    }
    public Wonder(int id, string name, string nation)
    {
        this.mId = id;
        this.mName = name;
        this.mNation = nation;
        this.mImages = new List<string>();
        this.mRotation = new Vector3();
    }
    public int getId()
    {
        return this.mId;
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
    public void addImage(string path)
    {
        this.mImages.Add(path);
    }
    public void setRotationX(float x)
    {
        this.mRotation.x = x;
    }
    public void setRotationY(float y)
    {
        this.mRotation.y = y;
    }
    public void setRotationZ(float z)
    {
        this.mRotation.z = z;
    }
    
}
