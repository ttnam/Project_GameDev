using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DialogPanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void go()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void option()
    {
        SceneManager.LoadScene("OptionScene");

    }
    public void contact()
    {
        Application.OpenURL("https://www.google.com");
    }

    public void exit()
    {
        Application.Quit();
    }
}
