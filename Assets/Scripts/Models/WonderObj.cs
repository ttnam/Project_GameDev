using Assets.Scripts.Globals;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WonderObj : MonoBehaviour
{
    //[SerializeField]
    public int wonderId;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit))
            {
                string tag = raycastHit.collider.transform.tag;
                if (tag.Substring(0, 6) == "Wonder")
                    SceneManager.LoadScene(Global.DETAIL_SCENE);
                    Global.CURR_WONDER = int.Parse(tag.Substring(7, 2));
                    Global.PREV_SCENE = Global.MAIN_SCENE;
                    Global.CURR_SCENE = Global.DETAIL_SCENE;
                    return;
                }
        }
    }
}
