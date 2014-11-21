using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour {

	public int speed = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += -(transform.right * speed * Time.deltaTime);
		this.transform.Rotate (Input.GetAxis ("Horizontal"), 0.0f, -Input.GetAxis("Vertical"));
	}
}
