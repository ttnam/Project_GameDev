using Assets.Scripts.Globals;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WonderObj : MonoBehaviour
{
    [SerializeField]
    private int wonderId;

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
                if (raycastHit.collider.transform.tag == "Wonder")
                {
                    Global.CURR_WONDER = wonderId;
                    SceneManager.LoadScene(Global.DETAIL_SCENE);
                }
            }
        }
    }
}
