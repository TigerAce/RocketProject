using UnityEngine;
using System.Collections;

public class PlayerOperation : MonoBehaviour {

	public GameObject prefab;
	GameObject spawn;

	GameObject airPlane;
	bool flying = false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.E)){
			if(!flying){
				this.gameObject.SetActive(false);
				spawn = GameObject.FindGameObjectWithTag("Spawn");
				airPlane = (GameObject)Instantiate(prefab, spawn.transform.position, spawn.transform.rotation);
				flying = true;
			}else{
				GameObject.Destroy(airPlane);
				this.gameObject.SetActive(true);
				flying = false;
			}
		}
	}
}
