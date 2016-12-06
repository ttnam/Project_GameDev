using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour {

    private float t = 0;
    public float dt = 0.01f;
    private short neg = 1;
    public ButtonCamera btn;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float x = Mathf.Sin(t) * 2;
        float z = Mathf.Sqrt(4 - Mathf.Sin(t) * Mathf.Sin(t) * 4);
 
        if (1 + Mathf.Sin(t) <= 0.0001)
            neg = 1;

        if (1 - Mathf.Sin(t) <= 0.0001)
            neg = -1;

        float type = 0;
        if (btn.changeCamera)
            type = Mathf.Cos(t * 2);


        transform.position = new Vector3(x, type, z * neg);
        transform.rotation = Quaternion.LookRotation(new Vector3(x, type, z * neg) * -1); 
        t += dt;  
    }
}
