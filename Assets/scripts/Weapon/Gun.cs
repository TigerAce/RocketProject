using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]
public class Gun : MonoBehaviour {
	public float rpm = 700;
	Animator anim;

	private float coolDown;
	private float nextShootTime;
	public float shootDistance;

	Camera cam;

	ParticleSystem [] ps;


	// Use this for initialization
	void Start () {
		
		cam = GetComponentInParent<Camera> ();
		shootDistance = 300;
		anim = this.GetComponent<Animator> ();
		ps = GetComponentsInChildren<ParticleSystem> ();

		if (anim != null) {
			Debug.Log("Found Animator");
		}

		coolDown = 60 / rpm;
	}
	
	// Update is called once per frame
	void Update () {


	}

	public void Shoot(){

		if (Shootable ()) {
			//play animation
			anim.SetTrigger("Shoot");
			//do raycast

			Ray ray = new Ray(cam.transform.position, cam.transform.forward);
			RaycastHit hit;
			if(Physics.Raycast(ray,out hit, shootDistance)){
				//hit.transform.gameObject.GetComponent<PlayerHealth>()
			}
			

			//calculate cooldown time
			nextShootTime = Time.time + coolDown;

			//play shoot sound
			audio.Play();

			foreach(ParticleSystem p in ps){
				p.Emit (1);
			}
		

		}
	}

	public void Reload(){
		anim.SetTrigger("DoReload");
	}

	private bool Shootable(){
		bool shootable = true;

		if (Time.time < nextShootTime) {
			shootable = false;
		}

		return shootable;
	}
}
