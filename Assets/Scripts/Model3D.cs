using UnityEngine;
using System.Collections;
using Assets.Scripts.Globals;

public class Model3D : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Transform>().GetChild(Global.CURR_WONDER - 1 ).gameObject.SetActive(Global.isShowed);
    }
        
}
