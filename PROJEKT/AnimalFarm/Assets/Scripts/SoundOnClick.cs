using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnClick : MonoBehaviour {

	public AudioClip myclip;

	private void OnMouseDown()
	{
		this.GetComponent<AudioSource>().Play();
	}

	private void OnMouseOver()
	{
		if (Input.GetKeyDown(KeyCode.Z))
		{
			this.GetComponent<AudioSource>().Play();
		}

		if (Input.GetKeyDown(KeyCode.X))
		{
			this.GetComponent<AudioSource>().Play();
		}
	}

	private void OnBecameInvisible()
	{

	}

	void Start () {
		this.gameObject.AddComponent<AudioSource>();
		this.GetComponent<AudioSource>().clip = myclip;
		this.myclip = GetComponent<AudioClip> ();
	}

	void Update () {

	}
}