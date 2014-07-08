using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

	float r = 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(0.8f, Mathf.Sin (r * Mathf.PI / 180), -15f);
		r += 2.0f;
		if(r > 360.0f){
			r = 0.0f;
		}

	}
}
