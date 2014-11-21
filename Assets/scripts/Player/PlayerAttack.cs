using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {
	public int damage = 10;
	public GameObject target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.F)) {
			Attack();
		}
	}

	private void Attack(){
		//attack distance calculation
		float distance = Vector3.Distance (target.transform.position, this.transform.position);

		//attack direction
		Vector3 dir = (target.transform.position - this.transform.position).normalized;
		//if direction > 0 --> infront , == 0 --> beside  , < 0 --> behind
		// V1 dot V2 = |V1||V2|Cosx
		float direction = Vector3.Dot (dir, this.transform.forward);

		if (distance <= 2.5f) {
			if(direction > 0){
						PlayerHealth enemyHealth = (PlayerHealth)target.GetComponent ("PlayerHealth");
						enemyHealth.AlterHealth (-damage);
			}
		}
	}
}
