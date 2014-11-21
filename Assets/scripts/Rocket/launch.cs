using UnityEngine;
using System.Collections;

public class launch : MonoBehaviour {
	bool go = false;
	public int currSpeed = 0;
	public int maxSpeed = 200;

	// Use this for initialization
	void Start () {
		Physics.IgnoreCollision (GameObject.FindGameObjectWithTag ("rocket").collider, this.collider);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.L)) {
			go = true;

		}
		if (go) {
			this.rigidbody.AddForce(Vector3.up * 1000 * Time.deltaTime);
		}

	}
}
