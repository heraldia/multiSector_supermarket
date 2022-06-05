using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log("cube-target begin collision");

		var tag = collision.collider.tag;

		Debug.Log("Tag is " + tag);
		Destroy(this.gameObject);


	}
	// 开始接触
	void OnTriggerEnter(Collider collider) {
		Debug.Log("cube-target 开始接触");
		Destroy (collider.gameObject);
	}

	// 接触结束
	void OnTriggerExit(Collider collider) {
		Debug.Log("cube-target 接触结束");
	}

	// 接触持续中
	void OnTriggerStay(Collider collider) {
		Debug.Log("cube-target 接触持续中");
	}

	// 碰撞结束
	void OnCollisionExit(Collision collision) {
		Debug.Log("cube-target end collision");
	}

	// 碰撞持续中
	void OnCollisionStay(Collision collision) {
		Debug.Log("cube-target during collision");

	}
}
