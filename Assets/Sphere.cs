using UnityEngine;
using System.Collections;

public class Sphere : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate (new Vector3(-0.05f, 0.0f, 0.0f));
		if(gameObject.transform.position.x < -3){
			gameObject.transform.position = new Vector3(4, 0, -13);
		}
	}

	void OnTriggerEnter2D(Collider2D c){
		Debug.Log ("CollisionEnter");
		//enabled = false;
	}

	void OnTriggerStay2D(Collider2D c){
		//Debug.Log ("CollisionStay");
	}
	void OnTriggerExit2D(Collider2D c){
		Debug.Log ("CollisionExit");
	}
}
