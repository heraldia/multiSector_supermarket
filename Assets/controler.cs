using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour {
    public float mSpeed;

	// Use this for initialization
	void Start () {
        mSpeed = 7f;
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(mSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, mSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
		
	}


	// 开始接触
	void OnTriggerEnter(Collider collider) {
		Debug.Log("body collider 开始接触");
		Destroy (collider.gameObject);
	}
	/*
	// 接触结束
	void OnTriggerExit(Collider collider) {
		Debug.Log("接触结束");
	}

	// 接触持续中
	void OnTriggerStay(Collider collider) {
		Debug.Log("接触持续中");
	}

	// 碰撞开始
	void OnCollisionEnter(Collision collision) {
		// 销毁当前游戏物体
		Destroy(this.gameObject);
	}

	// 碰撞结束
	void OnCollisionExit(Collision collision) {

	}

	// 碰撞持续中
	void OnCollisionStay(Collision collision) {

	}
	*/
}

