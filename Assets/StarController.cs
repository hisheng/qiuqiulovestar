using UnityEngine;
using System.Collections;

public class StarController : MonoBehaviour {

	public GameObject[] stars;
	public float shoottime;


	// Use this for initialization
	void Start () {
		shoottime = 0;
		 
			
	}
	
	// Update is called once per frame
	void Update () {
		shoottime = shoottime + Time.deltaTime;
		if(shoottime > 1){
			Instantiate(stars[Random.Range(0,4)], new Vector3(Random.value*10.0f-5.0f, 4, 0), Quaternion.identity);
			shoottime = 0;
		}
	}



}
