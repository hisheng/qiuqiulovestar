using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Rigidbody2D rb2d;
	public float speed;
	public int score;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		score = 5; 
		SetScoreText ();
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	void FixedUpdate() {
		float horizontal = Input.GetAxis ("Horizontal");

		rb2d.velocity = new Vector3(horizontal, 0, 0)*speed; 
		 
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag("bluestar")){
			score++;
			Destroy(other.gameObject);
		}
		if(other.CompareTag("star")){
			score--;
			Destroy(other.gameObject);
		}
		SetScoreText ();
		Debug.Log (score);
	}

	void SetScoreText(){
		scoreText.text = "收集的星星数：" + score.ToString ();
	}


}
