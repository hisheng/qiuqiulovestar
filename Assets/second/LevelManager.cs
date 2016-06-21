using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class LevelManager : MonoBehaviour {

	public Transform mainMenu, optionMenus;



	public	void LoadScene(string name){
		//Application.LoadLevel (name);
		SceneManager.LoadScene(name);
	}

	public void QuitGame(){
		Application.Quit ();
	}

	public void OptionMenu(bool clicked){
		if (clicked) {
			optionMenus.gameObject.SetActive (clicked);	
			mainMenu.gameObject.SetActive (false);
		} else {
			optionMenus.gameObject.SetActive (clicked);	
			mainMenu.gameObject.SetActive (true);
		}
	}


}
