using UnityEngine;
using System.Collections;

public class PlayManager : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)){
			anim.SetInteger ("state", 1);
		}

		if(Input.GetKey(KeyCode.R)){
			anim.SetInteger ("state", 2);
		}

	}
}
