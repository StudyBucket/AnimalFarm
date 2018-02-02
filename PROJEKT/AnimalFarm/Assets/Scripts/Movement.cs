using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        float speed = 10f;
        if (Mathf.Abs(vertical) > 0.01)
        {
            //move in the direction of the camera
            transform.position = transform.position + Camera.main.transform.forward * vertical * speed * Time.deltaTime;
        }
        if (Mathf.Abs(horizontal) > 0.01)
        {
            //strafe sideways
            transform.position += new Vector3(0, 0, -horizontal * speed * Time.deltaTime);
        }
    }
}
