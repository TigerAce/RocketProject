using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	public int maxHealth = 100;
	public int currHealth;

	public float currHealthBarLength;
	public float maxHealthBarLength;
	// Use this for initialization
	void Start () {
		currHealth = maxHealth;
		maxHealthBarLength = Screen.width / 3;
		currHealthBarLength = maxHealthBarLength;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void AlterHealth(int amount){
		currHealth += amount;

		if (currHealth >= maxHealth) {
						currHealth = maxHealth;
		} else if (currHealth <= 0) {
			currHealth = 0;
			this.Die();
		}

		currHealthBarLength = maxHealthBarLength * (currHealth / maxHealth);
	}
	public void Die(){
	
	}
	public void OnGUI(){
		GUI.Box (new Rect (10, 10, currHealthBarLength, 20), currHealth + "/" + maxHealth);
	}
}
