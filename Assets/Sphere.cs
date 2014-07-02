using UnityEngine;
using System.Collections;

public class Sphere : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate (new Vector3(-0.05f, 0.0f, 0.0f));
	}

	void OnTriggerEnter2D(Collider2D c){
		Debug.Log ("Collision");
		//enabled = false;
	}
}
