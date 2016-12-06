using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonCamera : MonoBehaviour {

    public Button btnCamera;
    public bool changeCamera = false;

    // Use this for initialization
    void Start () {
        Button btn = btnCamera.GetComponent<Button>();
        btn.onClick.AddListener(Click);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void Click() {
        changeCamera = !changeCamera;
    }
}
