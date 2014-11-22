using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerHealth))]
public class PlayerHealthBar : HealthBar {
	
	public PlayerHealth playerHealth; 
	// Use this for initialization
	void Start () {
		playerHealth = GameObject.FindObjectOfType<PlayerHealth> ();
		maxHealthBarLength = Screen.width / 3;
		currHealthBarLength = maxHealthBarLength;

	}

	public void OnGUI(){
		GUI.Box (new Rect (10, 10, currHealthBarLength, 20), playerHealth.currHealth + "/" + playerHealth.maxHealth);
	}
}
