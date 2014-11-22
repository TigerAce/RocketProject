using UnityEngine;
using System.Collections;

public class PlayerFire : MonoBehaviour {
	Gun gun;
	// Use this for initialization
	void Start () {

		gun = GetComponentInChildren<Gun>();
		if (gun != null) {
						Debug.Log ("fOUND GUN");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1")) {
			gun.Shoot();
		}
		
		if (Input.GetKeyUp (KeyCode.R)) {
			gun.Reload();
		}
	}
}
