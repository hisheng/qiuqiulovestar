using UnityEngine;
using System.Collections;

public class SolidController : MonoBehaviour {
	//public Transform ca;

	// Use this for initialization
	void Start () {

		 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag("star")){
			Destroy(other.gameObject);
		}
		if(other.CompareTag("bluestar")){
			Destroy(other.gameObject);
		}
	}
}
