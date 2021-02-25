using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yerde_mi : MonoBehaviour {
	public LayerMask layer; 
	public bool yerde_miyim;
	public Rigidbody2D rigitbod;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit2D carpisma = Physics2D.Raycast (transform.position, Vector2.down, 0.1f, layer);
		if (carpisma.collider != null) {
			yerde_miyim = true;
		} else {
			yerde_miyim = false;
		}
		if (Input.GetKeyDown (KeyCode.Space) && yerde_miyim == true) {
			rigitbod.velocity += new Vector2 (0, 5F);
		} 
		else if (Input.GetKeyDown (KeyCode.W) && yerde_miyim == true) {
			rigitbod.velocity += new Vector2 (0, 5F);
		} 
		else if (Input.GetKeyDown (KeyCode.UpArrow) && yerde_miyim == true) {
			rigitbod.velocity += new Vector2 (0, 5F);
		}
	}
}
