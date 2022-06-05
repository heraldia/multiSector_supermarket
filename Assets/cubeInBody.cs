using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeInBody : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider collider) {
		Debug.Log("cube in body 开始接触");
		Destroy (collider.gameObject);

	}

}
