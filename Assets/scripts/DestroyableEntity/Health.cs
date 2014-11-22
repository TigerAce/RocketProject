using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	public int maxHealth = 100;
	public int currHealth;

	// Use this for initialization
	void Start () {
		currHealth = maxHealth;
	}

	//alter health value if amout is < 0 then decrease current health if amout > 0 incerease current health
	public void AlterHealth(int amount, HealthBar healthBar){
		currHealth += amount;

		if (currHealth >= maxHealth) {
			currHealth = maxHealth;
		} else if (currHealth <= 0) {
			currHealth = 0;
			//if currHealth <= 0 entity dead
			this.Die();
		}
		healthBar.AlterHealthBar (currHealth, maxHealth);
	}
	public virtual void Die(){
		Debug.Log ("die");
	}
}
