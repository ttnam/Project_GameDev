using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Assets.Scripts.Globals;

public class DialogPanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void go()
    {
        SceneManager.LoadScene(Global.DETAIL_SCENE);
        Global.PREV_SCENE = Global.SPLASH_SCENE;
        Global.CURR_SCENE = Global.DETAIL_SCENE;
    }
    public void earth()
    {
        SceneManager.LoadScene(Global.MAIN_SCENE);
        Global.PREV_SCENE = Global.SPLASH_SCENE;
        Global.CURR_SCENE = Global.MAIN_SCENE;
    }
    public void contact()
    {
        SceneManager.LoadScene(Global.MODEL3D_SCENE);
        Global.PREV_SCENE = Global.SPLASH_SCENE;
        Global.CURR_SCENE = Global.MODEL3D_SCENE;
    }

    public void exit()
    {
        Application.Quit();
    }
}
