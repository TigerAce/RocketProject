using UnityEngine;
using System.Collections;

public class MissileLunch : MonoBehaviour {

	public int speed = 300;
	public GameObject target;

	Vector3 direction;
	// Use this for initialization
	void Start () {
		this.audio.Play ();
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += ( transform.forward * speed * Time.deltaTime );
	}
}
