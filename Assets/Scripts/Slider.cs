using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts.Globals;

public class Slider : MonoBehaviour
{

    private int index;
    private ArrayList imagesBuffer = new ArrayList();

    // Use this for initialization
    void Start()
    {
        onLoadImages();
        index = Global.CURR_WONDER - 1;

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void onLoadImages()
    {
        Object[] images = Resources.LoadAll("Images");
        for (int i = 0; i < images.Length; ++i)
        {
            imagesBuffer.Add(images[i]);
        }
        GetComponent<RawImage>().texture = (Texture)imagesBuffer[Global.CURR_WONDER - 1];
    }


    public void onNext()
    {
        int curr = (index + 1) >= imagesBuffer.Count ? imagesBuffer.Count - 1 : ++index;
        GetComponent<RawImage>().texture = (Texture)imagesBuffer[curr];
        Global.CURR_WONDER = curr + 1;
    }
    public void onPrev()
    {
        int curr = (index - 1) <= 0 ? 0 : --index;
        GetComponent<RawImage>().texture = (Texture)imagesBuffer[curr];
        Global.CURR_WONDER = curr + 1;
    }
}
