using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Slider : MonoBehaviour
{

    private int index;
    private ArrayList imagesBuffer = new ArrayList();

    // Use this for initialization
    void Start()
    {
        onLoadImages();

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
        GetComponent<RawImage>().texture = (Texture)imagesBuffer[0];
    }


    public void onNext()
    {
       
        GetComponent<RawImage>().texture = (Texture)imagesBuffer[
            (index + 1) >= imagesBuffer.Count ? imagesBuffer.Count - 1 : index++];
    }
    public void onPrev()
    {
        GetComponent<RawImage>().texture = (Texture)imagesBuffer[
            (index - 1) <= 0 ? 0 : index--];
    }
}
