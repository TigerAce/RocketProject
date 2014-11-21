using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {

	public Camera standbyCamera;

	SpawnPoint[] spots;
	// Use this for initialization
	void Start () {
		Connect ();
		spots = GameObject.FindObjectsOfType<SpawnPoint>();
	}

	void Connect(){
		PhotonNetwork.ConnectUsingSettings("RocketProject ver 0.1");
	}

	void OnGUI(){
		GUILayout.Label (PhotonNetwork.connectionStateDetailed.ToString());
	}
	void OnJoinedLobby(){
		Debug.Log ("Join Lobby");
		PhotonNetwork.JoinRandomRoom ();
	}
	void OnPhotonRandomJoinFailed(){
		Debug.Log ("Creat Room");
		PhotonNetwork.CreateRoom (null);

	}

	void OnJoinedRoom(){
		Debug.Log ("Join Room");
		SpawnPlayer ();
	}

	void SpawnPlayer(){
		Debug.Log ("Spawn Player");
		if (spots == null) {
			Debug.Log("No Spawn Point Found!");

		}else{
			SpawnPoint mySpawnPoint = spots [Random.Range (0, spots.Length)];
			GameObject myPlayer = (GameObject)PhotonNetwork.Instantiate ("soldier", mySpawnPoint.transform.position, mySpawnPoint.transform.rotation, 0);
			standbyCamera.enabled = false;
			//((MonoBehaviour)myPlayer.GetComponent("FPSInputController")).enabled = true;
			((MonoBehaviour)myPlayer.GetComponent("MouseLook")).enabled = true;
			((MonoBehaviour)myPlayer.GetComponent("PlayerMovement")).enabled = true;
			myPlayer.transform.FindChild("PlayerCamera").gameObject.SetActive(true);
		}
	}

}
