using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	float speed = 10f;
	float jumpSpeed = 6f;
	Vector3 direction = Vector3.zero;
	float verticalVelocity = 0;
	CharacterController cc;
	Animator anim;
	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		direction = transform.rotation * new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		if (direction.magnitude > 1f) {
			direction = direction.normalized;
		}

		anim.SetFloat ("speed", direction.magnitude);

		if(cc.isGrounded && Input.GetButtonUp("Jump")){
			verticalVelocity = jumpSpeed;
		}


	}

	void FixedUpdate(){
		Vector3 dist = direction * speed * Time.deltaTime;
		verticalVelocity += Physics.gravity.y * Time.deltaTime;

		dist.y = verticalVelocity * Time.deltaTime;
		cc.Move (dist);
	}
}
