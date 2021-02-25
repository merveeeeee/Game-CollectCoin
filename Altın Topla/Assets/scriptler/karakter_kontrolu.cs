using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class karakter_kontrolu : MonoBehaviour {

	// Use this for initialization
	public float hiz ;
	public Animator animasyoncum;
	public int altin_miktari;
	public Text altin_miktari_text;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate(){
		float horizontal = Input.GetAxis ("Horizontal");
		transform.position += new Vector3 (horizontal*hiz*Time.deltaTime, 0, 0);

		bool kosuyorum = false;
		if (horizontal != 0) {
			kosuyorum = true;
		}
		animasyoncum.SetBool ("kosuyor_muyum", kosuyorum);

		if (horizontal > 0) {
			transform.localScale = new Vector3(1,1,1);
		}
		else if (horizontal<0){
			transform.localScale = new Vector3(-1,1,1);
		}

	}

	void OnTriggerEnter2D(Collider2D carpilan_nesne){
		if (carpilan_nesne.tag == "altinlar"){
			altin_miktari ++ ;
			altin_miktari_text.text = altin_miktari.ToString();
			Destroy (carpilan_nesne.gameObject);

		}
	}

	void LateUpdate(){

	}
}
