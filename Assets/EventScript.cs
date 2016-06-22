using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EventScript : MonoBehaviour {

	 


	public	void LoadScene(string name){
		//Application.LoadLevel (name);
		print("sssss");
		SceneManager.LoadScene(name);
	}
}
