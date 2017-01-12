using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Wonder
{

    private string id;
    private string name;
    private string nation;
    private int[] view = new int[3];
    private List<string> images;


    public Wonder()
    {
        this.id = "";
        this.name = "";
        this.nation = "";
        this.view[0] = 0;
        this.view[1] = 0;
        this.view[2] = 0;
        this.images = new List<string>();
    }

}
