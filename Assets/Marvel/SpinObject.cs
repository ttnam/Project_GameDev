using UnityEngine;
using System.Collections;

public class SpinObject : MonoBehaviour {
    public GameObject earth;
    

    private void Start()
    {
        transform.SetParent(earth.transform);
    }

    private void Update()
    {
        
    }
}
