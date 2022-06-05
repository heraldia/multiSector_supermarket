using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motioncontrol : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
float rotationSpeed = 50.0F;
        float rotation = 1;
        if (Input.GetKey(KeyCode.G))
        {
            rotation = -1 * rotationSpeed;
            rotation *= Time.deltaTime;
            transform.Rotate(0, rotation, 0);
        }
        if (Input.GetKey(KeyCode.H))
        {
            rotation = 1 * rotationSpeed;
            rotation *= Time.deltaTime;
            transform.Rotate(0, rotation, 0);
        }


    }
}
