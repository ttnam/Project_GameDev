using UnityEngine;
using System.Collections;

public class SpinModel : MonoBehaviour {

    public bool spin;
    public float speed = 10f;

    private float direction = 1f;
    private float directionChangeSpeed = 2f;

    // Update is called once per frame
    void Update()
    {
        if (direction < 1f)
            direction += Time.deltaTime / (directionChangeSpeed / 2);

        if (spin)
            transform.Rotate(0, 1, 0);
            //transform.Rotate(-Vector3.down, (speed * direction) * Time.deltaTime);
    }
}
