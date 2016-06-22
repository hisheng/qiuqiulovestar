using UnityEngine;
using System.Collections;

public class StarController : MonoBehaviour {
//	public Transform panel;
	public GameObject[] stars;
	public float shoottime;

	private float width;

	// Use this for initialization
	void Start () {
		shoottime = 0;
		//width = Screen.width;
		//print (width);
			
	}
	
	// Update is called once per frame
	void Update () {
		shoottime = shoottime + Time.deltaTime;
		if(shoottime > 1){
			GameObject obj = Instantiate(stars[Random.Range(0,4)], new Vector3(Random.value*10.0f-5.0f, 4, 0), Quaternion.identity) as GameObject;
//			GameObject obj = Instantiate(stars[Random.Range(0,4)]) as GameObject;
//			obj.transform.SetParent (panel);
//			obj.transform.localPosition = new Vector3 (Random.Range (-Screen.width / 2, Screen.width / 2), 0, 0);
			shoottime = 0;
		}
	}



}
