using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {
	public float currHealthBarLength;
	public float maxHealthBarLength;

	public virtual void AlterHealthBar(int currHealth, int maxHealth){
		if (maxHealth != 0) {
			currHealthBarLength = maxHealthBarLength * (currHealth / maxHealth);
		}
	}
}
