using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creep : MonoBehaviour {

	public GameObject Player;
	public float speed = 1.0f;
	public float MinimumDistance = 5.5f;

	void Start () {
		Player = GameObject.Find("FirstPersonCharacter");
	}

	void Update () {
		doTheCreepyFollow ();
		doTheCreepyTurn ();
		/*
		float interpolation = speed * Time.deltaTime;
		Vector3 position = this.transform.position;
		var MinimumDistance = 3.5f;
		Vector3 PlayerPos = objectToFollow.transform.position;
		Vector3 newPosGround = PlayerPos;
		newPosGround.y = -11.29767f;
		Vector3 Direction = (transform.position - PlayerPos).normalized;
		Direction.y = -11.29767f;
		this.transform.position = objectToFollow.transform.position + Direction * MinimumDistance;
		*/
	}

	void doTheCreepyTurn(){
		this.transform.LookAt (Player.transform);
		//this.transform.Rotate (new Vector3 (0, 0, 0));
		this.transform.Rotate (new Vector3 (0, 180,0));
		this.transform.eulerAngles = new Vector3(-90,this.transform.eulerAngles.y,this.transform.eulerAngles.z);
	}

	void doTheCreepyFollow(){

		Vector3 newPos = (this.transform.position - Player.transform.position).normalized * MinimumDistance + Player.transform.position;

		//Vector3 Direction = (transform.position - Player.transform.position).normalized;
		//Vector3 newPos = Player.transform.position + Direction * MinimumDistance;

		//this.transform.position = new Vector3 (newPos.x, newPos.y, newPos.z);
		//this.transform.position = new Vector3 (newPos.x, Player.transform.position.y - 2.21f, newPos.z); //

		this.transform.position = new Vector3 (newPos.x, 100.07f, newPos.z);
	}
}
