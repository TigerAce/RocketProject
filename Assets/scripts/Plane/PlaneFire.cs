using UnityEngine;
using System.Collections;

public class PlaneFire : MonoBehaviour {
	public GameObject missile;
	GameObject m;
	public Transform missileSpawnPoint;
	// Use this for initialization
	void Start () {
		missileSpawnPoint = this.transform.FindChild ("MissileLaunchPoint");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.G)) {

			m = (GameObject)Instantiate(missile, missileSpawnPoint.position, missileSpawnPoint.rotation);

		}
	}
}
